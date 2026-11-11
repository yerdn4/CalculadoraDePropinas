using CalculadoraDePropinas.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
namespace CalculadoraDePropinas.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _importeDelConsumo = string.Empty;
        [ObservableProperty]
        private string _numeroDePersonas = "1";
        [ObservableProperty]
        private string _porcentajeDePropina = "10";

        [ObservableProperty]
        private string _importeDelConsumoPorPersona = string.Empty;
        [ObservableProperty]
        private string _importeDeLaPropina = string.Empty;
        [ObservableProperty]
        private string _importeDeLaPropinaPorPersona = string.Empty;
        [ObservableProperty]
        private string _importeDelConsumoConPropina = string.Empty;
        [ObservableProperty]
        private string _importeDelConsumoConPropinaPorPersona = string.Empty;

        public MainViewModel()
        {
            ImporteDelConsumo = string.Empty;
            NumeroDePersonas = "1";
            PorcentajeDePropina = "10";
        }

        [RelayCommand]
        public void Calcular()
        {
            decimal importeDelConsumo;
            int numeroDePersonas;
            decimal porcentajeDePropina;
            bool importeDelConsumoEsValido = decimal.TryParse(ImporteDelConsumo, out importeDelConsumo);
            bool numeroDePersonasEsValido = int.TryParse(NumeroDePersonas, out numeroDePersonas);
            bool porcentajeDePropinaEsValido = decimal.TryParse(PorcentajeDePropina, out porcentajeDePropina);
            if (importeDelConsumoEsValido && numeroDePersonasEsValido && porcentajeDePropinaEsValido)
            {
                var consumo = new ConsumoCompartido(importeDelConsumo, numeroDePersonas, porcentajeDePropina);
                ImporteDelConsumoPorPersona = consumo.ImporteDeLaPropinaPorPersona.ToString("c2");
                ImporteDeLaPropina = consumo.ImporteDeLaPropina.ToString("c2");
                ImporteDeLaPropinaPorPersona = consumo.ImporteDeLaPropinaPorPersona.ToString("c2");
                ImporteDelConsumoConPropina = consumo.ImporteDeConsumoConPropina.ToString("c2");
                ImporteDelConsumoConPropinaPorPersona = consumo.ImporteDeConsumoConPropinaPorPersona.ToString("c2");

            }
        }
        [RelayCommand]
        public void CambiarPorcentajeDePropina(string nuevoPorcentajeDePropina)
        {
            PorcentajeDePropina = nuevoPorcentajeDePropina;
        }

        [RelayCommand]
        public void Limpiar()
        {
            ImporteDelConsumo = string.Empty;
            NumeroDePersonas = "1";
            PorcentajeDePropina = "10";

            ImporteDelConsumoPorPersona = string.Empty;
            ImporteDeLaPropina = string.Empty;
            ImporteDeLaPropinaPorPersona = string.Empty;
            ImporteDelConsumoConPropina = string.Empty;
            ImporteDelConsumoConPropinaPorPersona = string.Empty;
        }

    }
}