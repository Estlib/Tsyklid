// See https://aka.ms/new-console-template for more information

string kasutajaNimi = "";
do
{
    Console.WriteLine("Palun sisesta oma kasutajanimi");
    kasutajaNimi = Console.ReadLine();
}
while (kasutajaNimi != "user1");
if (kasutajaNimi == "user1")
{
    int ruuduSuurus = 0;
    
    do
    {
        Console.WriteLine("Kui suurt ruutu tahad?");
        ruuduSuurus = int.Parse(Console.ReadLine());
    } while (ruuduSuurus < 0 && ruuduSuurus > 20);
    char reaKujund = '▓';
    string üksRida = "";
    int tsükliMuutuja = ruuduSuurus;
    do
    {
        üksRida += "_"+reaKujund;
        tsükliMuutuja -= 1;
    } while (tsükliMuutuja != 0);
    tsükliMuutuja = ruuduSuurus;
    do
    {
        Console.WriteLine(üksRida);
        tsükliMuutuja -= 1;

    } while (tsükliMuutuja != 0);
}