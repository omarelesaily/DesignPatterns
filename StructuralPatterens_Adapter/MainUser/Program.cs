// Client code
using StructuralPatterens_Adapter.AdapteeClasses;
using StructuralPatterens_Adapter.AdapterClass;

class Program
{
    static void Main(string[] args)
    {
        IPowerSocket europeanSocket = new EuropeanSocket();
        IPowerSocket ukSocket = new UKSocket();
        IPowerSocket indianSocket = new IndianSocket();

        // Use the universal adapter to convert from any type to US
        IUSPowerPlug usAdapter = new UniversalPowerAdapter(europeanSocket);
        usAdapter.ProvidePower();
        //OutPut : Providing 230V power using a round plug (EuropeanSocket).
        //Converted to 120V power using a flat plug(US standard).

        usAdapter = new UniversalPowerAdapter(ukSocket);
        usAdapter.ProvidePower();
        //OutPut : Providing 240V power using a rectangular plug(UKSocket).
        //Converted to 120V power using a flat plug(US standard).

        usAdapter = new UniversalPowerAdapter(indianSocket);
        usAdapter.ProvidePower();
        //OutPut : Providing 230V power using a three-pin plug (IndianSocket).
        //Converted to 120V power using a flat plug (US standard).
    }
}
