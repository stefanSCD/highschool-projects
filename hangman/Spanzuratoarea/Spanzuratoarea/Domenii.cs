using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spanzuratoarea
{
    public static class Domenii
    {
        // Tari și Capitale
        public static string[] tariCapitale = new string[]
        {
            "Bucuresti", "Budapesta", "Berlin", "Londra", "Paris",
            "Roma", "Viena", "Madrid", "Atena", "Varsovia",
            "Amsterdam", "Lisabona", "Praga", "Sofia", "Dublin",
            "Belgrad", "Moscova", "Oslo", "Helsinki", "Stockholm",
            "Copenhaga", "Ankara", "Berna", "Bruxelles", "Luxemburg"
        };

        // Nume de animale
        public static string[] numeAnimale = new string[]
        {
            "Leu", "Elefant", "Tigru", "Girafa", "Cangur",
            "Panda", "Papagal", "Vulpe", "Iepure", "Broasca",
            "Caine", "Veverita", "Cocor", "Lup", "Pisica",
            "Maimuta", "Cocodril", "Rinocer", "Rechin", "Pinguin",
            "Urs", "Vaca", "Oaie", "Porc", "Cal"
        };

        // Meserii
        public static string[] meserii = new string[]
        {
            "Doctor", "Profesor", "Inginer", "Avocat", "Arhitect",
            "Actor", "Pictor", "Scriitor", "Mecanic", "Bucatar",
            "Fermier", "Electrician", "Marinar", "Asistent", "Programator",
            "Jurnalist", "Chelner", "Politist", "Bibliotecar", "Artist",
            "Economist", "Medic veterinar", "Fotograf", "Antreprenor", "Pompier"
        };

        // Nume de plante
        public static string[] numePlante = new string[]
        {
            "Trandafir", "Liliac", "Zambila", "Margareta", "Ghiocel",
            "Lalea", "Crin", "Orhidee", "Feriga", "Brusture",
            "Iedera", "Vioara", "Musetel", "Frunza", "Pin"
        };

        // Vedete de film
        public static string[] vedeteFilm = new string[]
        {
            "Brad Pitt", "Angelina Jolie", "Leonardo DiCaprio", "Meryl Streep", "Tom Hanks",
            "Jennifer Lawrence", "Johnny Depp", "Scarlett Johansson", "Denzel Washington", "Emma Stone",
            "Will Smith", "Natalie Portman", "Robert De Niro", "Charlize Theron", "Matt Damon",
            "Cate Blanchett", "George Clooney", "Julia Roberts", "Tom Cruise", "Nicole Kidman",
            "Morgan Freeman", "Anne Hathaway", "Samuel L. Jackson", "Jennifer Aniston", "Christian Bale"
        };

        // Mărci de mașini
        public static string[] marciMasini = new string[]
        {
            "Mercedes", "BMW", "Audi", "Toyota", "Honda",
            "Ford", "Volkswagen", "Volvo", "Ferrari", "Porsche",
            "Chevrolet", "Tesla", "Jaguar", "Lamborghini", "Subaru",
            "Maserati", "Jeep", "Hyundai", "Kia", "Lexus",
            "Nissan", "Renault", "Peugeot", "Skoda", "Mazda"
        };

        // Cuvinte din domeniul tehnologic
        public static string[] cuvinteTehnologie = new string[]
        {
            "Calculator", "Telefon", "Internet", "Program", "Retea",
            "Baza de date", "Software", "Hardware", "Ecran", "Tastatura",
            "Mouse", "Tableta", "Sistem de operare", "Aplicatie", "Webcam",
            "Router", "Procesor", "Memorie", "Port", "Touchscreen",
            "Bluetooth", "Wi-Fi", "Pixel", "Senzor", "Algoritm"
        };

        // Nume de fructe și legume
        public static string[] fructeLegume = new string[]
        {
            "Mar", "Banane", "Portocale", "Struguri", "Pere",
            "Castravete", "Morcovi", "Rosii", "Cartofi", "Vinete",
            "Capsuni", "Pepene", "Ananas", "Lamaie", "Varza",
            "Broccoli", "Spanac", "Cireșe", "Piersici", "Kiwi",
            "Prune", "Ardei", "Dovleac", "Ceapa", "Usturoi"
        };

        // Cuvinte asociate cu sportul
        public static string[] cuvinteSport = new string[]
        {
            "Fotbal", "Baschet", "Tenis", "Volei", "Golf",
            "Schi", "Înot", "Ciclism", "Atletism", "Box",
            "Rugby", "Handbal", "Karate", "Judo", "Fotbal american",
            "Formula 1", "Wrestling", "Skateboard", "Surf", "Hockey",
            "Badminton", "Ping pong", "Canotaj", "Scrima", "Gimnastica"
        };

        // Nume de orașe
        public static string[] orase = new string[]
        {
            "New York", "Paris", "Londra", "Tokio", "Roma",
            "Sydney", "Moscova", "Berlin", "Rio de Janeiro", "Istanbul",
            "Cairo", "Mumbai", "Toronto", "Dubai", "Los Angeles",
            "Barcelona", "Bangkok", "Viena", "Amsterdam", "Chicago",
            "Seoul", "Madrid", "Praga", "Budapesta", "Viena"
        };

        // Nume de culori
        public static string[] culori = new string[]
        {
            "Rosu", "Albastru", "Verde", "Galben", "Portocaliu",
            "Violet", "Roz", "Negru", "Alb", "Maro",
            "Gri", "Bej", "Turcoaz", "Lila", "Turcoaz",
            "Auriu", "Argintiu", "Coral", "Ciano", "Indigo",
            "Magenta", "Mare", "Kaki", "Tur", "Lavanda"
        };

        public static string[] partiCorp = new string[]
        {
            "Cap", "Umar", "Brat", "Mana", "Deget",
            "Gat", "Spate", "Piept", "Coasta", "Burta",
            "Talie", "Sold", "Picior", "Genunchi", "Glezna",
            "Talpa", "Par", "Ochi", "Nas",
            "Gura", "Buze", "Barbie", "Ureche", "Buza"
        };

        // Cuvinte din domeniul alimentației
        public static string[] alimente = new string[]
        {
            "Paine", "Branza", "Carne", "Peste", "Legume",
            "Fructe", "Paste", "Orez", "Lactate", "Sos",
            "Miere", "Gem", "Salata", "Pizza", "Tort",
            "Cafea", "Ceai", "Suc", "Apa", "Bere",
            "Vin", "Sampanie", "Whisky", "Cognac", "Vodca"
        };

        // Nume de branduri de îmbrăcăminte
        public static string[] branduriImbracaminte = new string[]
        {
            "Nike", "Adidas", "Gucci", "H&M", "Zara",
            "Calvin Klein", "Versace", "Prada", "Levi's", "Armani",
            "Chanel", "Tommy Hilfiger", "Puma", "Burberry", "Diesel",
            "Dolce & Gabbana", "Fendi", "Under Armour", "Ralph Lauren", "Gap",
            "Forever 21", "Vans", "Guess", "Victoria's Secret", "Balenciaga"
        };

    }
}
