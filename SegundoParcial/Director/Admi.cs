using SegundoParcial.Buiders;
using SegundoParcial.Models;

namespace SegundoParcial.Director
{
    public class Admi
    {
        private CBuilder _cBuilder;

        public void RecepcionarProximaH(CBuilder pizzaBuilder)
        {
            _cBuilder = pizzaBuilder;
        }

        public void CocinarHamburguesaPasoAPaso()
        {
            _cBuilder.PasoNombre();
            _cBuilder.PasoTemperatura();
            _cBuilder.PasoMax();
            _cBuilder.PasoMin();
        }

        public Citi CityPreparada => _cBuilder.ObtenerCuidad();

        public Citi CocinarPizza(CBuilder hBuilder)
        {
            hBuilder.PasoNombre();
            hBuilder.PasoTemperatura();
            hBuilder.PasoMax();
            hBuilder.PasoMin();
            return hBuilder.ObtenerCuidad();
        }
    }
}
