namespace SalesFinal.Interfaces
{
    using System.Globalization;

    public interface ILocalize
    {
        CultureInfo GetCurrentCultureInfo();//informacion del telefono idioma del telefono
        void SetLocale(CultureInfo ci);//cambiar la configuracion del telefono
    }
}
