using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace MarketHub.Infrastructure.Conventions;

/// <summary>
/// Convención global que mapea FKs con el patrón "Id" + NombreEntidad.
/// EF por defecto espera "EntidadId". Con esto, nunca más hay que configurar FKs a mano.
/// </summary>
public class ForeignKeyNamingConvention : IModelFinalizingConvention
{
    public void ProcessModelFinalizing(IConventionModelBuilder eModelBuilder,
        IConventionContext<IConventionModelBuilder> eContext)
    {
        // Recolecto primero toda la info, después modifico.
        // Si modifico dentro del foreach, C# tira "Collection was modified"
        var iFksAConfigurar = new List<(IConventionForeignKey Fk, IConventionProperty Propiedad)>();

        foreach (var iEntidad in eModelBuilder.Metadata.GetEntityTypes())
        {
            foreach (var iForeignKey in iEntidad.GetForeignKeys().ToList())
            {
                if (iForeignKey.GetPropertiesConfigurationSource() == ConfigurationSource.Explicit)
                    continue;

                var iNavegacion = iForeignKey.DependentToPrincipal;
                if (iNavegacion == null)
                    continue;

                var iNombreFk = "Id" + iNavegacion.Name;
                var iPropiedad = iEntidad.FindProperty(iNombreFk);

                if (iPropiedad != null)
                    iFksAConfigurar.Add((iForeignKey, iPropiedad));
            }
        }

        // Ahora sí aplico los cambios, fuera del foreach original
        foreach (var (iFk, iPropiedad) in iFksAConfigurar)
        {
            iFk.SetProperties(new[] { iPropiedad }, iFk.PrincipalKey);
        }
    }
}
