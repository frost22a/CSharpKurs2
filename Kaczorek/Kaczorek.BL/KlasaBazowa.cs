namespace Kaczorek.BL
{
    public abstract class KlasaBazowa // Klasę bazową można storzyć jako klasę abstrakcyjną, albo jako "zwykłą" klasę
                            // klasa abstrakcyjna nie ma możliwości utworzenia swojej instancji (new nie zadziała)
                            //czy klasa ma być zapieczętowana? to znaczy, czy z tej klasy mogą dziedziczyć inne klasy  - nasza nie
    {
        public bool JestNowy { get; set; } // protected - do danej włąściwości mają dostęp - klasa bazowa oraz wszystkie klasy dziedziczące
        public bool MaZmiany { get; set; }
        public StanObiektuOpcje StanObiektu{ get; set; }

        public bool DanePrawidłowe 
        {
            get 
            {
                return Zwaliduj();    
            } 
        }

        //public virtual bool Zwaliduj() // przesłaniamy metodę w klasach pochodnych -> konieczne jest słowo kluczowe virtual albo abstract
        //{
        //    return true;
        //}

        public abstract bool Zwaliduj(); // jak jest abstract, to taka metoda nie ma własnej implementacji  - w naszym przykładzie zostajke abstract
                                         // nie wiemy jak ma być sprawdzana poprawność w tej klasie, tylko wiemy jak to wygląda w poszxczególnych klasach
    }

    public enum StanObiektuOpcje
    {
        Aktywny,
        Usuniety
    }


}

