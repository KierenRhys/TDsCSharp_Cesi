// EXERCICE 1 --
// La classe personne avec un atribut Age et deux méthodes : SetAge (définit l'âge de la personne) et SayHi (dit bonjour)
class Person // Person pour l'exo 1 =/= de Person pour l'exo 2
{
    protected int Age;

    public void SetAge(int n)
    {
        this.Age = n;
    }

    public virtual void SayHi()
    {
        Console.WriteLine("Bonjour");
    }
}

// La classe Student héritant de Person composée de deux méthodes GoToClasses indiquant que l'étudiant va en class et ShowAge qui indique l'âge de la personne (définit dans la class Person)
class Student : Person
{
    public void GoToClasses()
    {
        Console.WriteLine("Je vais en classe.");
    }

    public void ShowAge()
    {
        Console.WriteLine("Mon âge est {0} ans.", base.Age);
    }

    public override void SayHi()
    {
        Console.WriteLine("Yo, je suis un étudiant");
    }
}

// La classe Teacher héritant de Person composé d'un attribut Subject et d'une méthode Expliquer précisant que la professeur commence son explication
class Teacher : Person
{
    private string Subject;

    public void Expliquer()
    {
        Console.WriteLine("L'explication commence.");
    }

    public override void SayHi()
    {
        Console.WriteLine("Je vous souhaite le bon jour.");
    }
}

// Class pour tester l'exercice 1
class StudentAndTeacherTest
{
    static void Main(string[] args)
    {
        Console.WriteLine("La personne --");
        Person ulysse = new Person();
        ulysse.SayHi();

        Console.WriteLine("L'étudiant --");
        Student yannL = new Student();
        yannL.SetAge(21);
        yannL.SayHi();
        yannL.ShowAge();

        Console.WriteLine("Le professeur --");
        Teacher yannP = new Teacher();
        yannP.SetAge(30);
        yannP.SayHi();
        yannP.Expliquer();


        Console.ReadLine();
    }
}
// FIN EXERCICE 1 --

// EXERCICE 2 --
// La classe House possède un attribut Area, on lui attribut une porte de base qui si elle n'est pas définit la couleur sera "bois"
class House
{
    protected int Area;
    protected Door door;
    public House()
    {
        this.door = new Door();
    }
    public House(int area)
    {
        this.SetArea(area);
        this.door = new Door();
    }

    public void SetArea(int n)
    {
        this.Area = n;
    }

    public int GetArea()
    {
        return this.Area;
    }

    public Door GetDoor()
    {
        return this.door;
    }

    public void ShowData()
    {
        Console.WriteLine("house, my area is {0} m2", this.GetArea());
        door.ShowData();
    }
}

// La classe Door possède un attribut Color, qui, s'il n'est pas définit, est "bois" par défaut
class Door
{
    protected string Color;
    public Door(string color = "bois")
    {
        this.SetColor(color);
    }

    public void SetColor(string s)
    {
        this.Color = s;
    }

    public string GetColor()
    {
        return this.Color;
    }

    public void ShowData()
    {
        Console.WriteLine("Je suis une porte, ma couleur est {0}", this.GetColor());
    }
}

// La classe SmallApartement hérite de House avec l'attribut Area = 50 dans tous les cas.
class SmallApartment : House
{
    public SmallApartment()
    {
        base.SetArea(50);
    }
}

// La class person possède un attribut Nom, il a un constructeur de base et une surchage avec une House et un nom, il possède une méthode ShowData() donnant son nom mais aussi la surface de sa House et la couleur de sa porte
class Person
{
    protected string Nom;
    protected House House;
    public Person()
    {

    }
    protected Person(House house, string nom)
    {
        SetNom(nom);
        SetHouse(house);
    }

    public void SetNom(string nom)
    {
        this.Nom = nom;
    }

    public void SetHouse(House house)
    {
        this.House = house;
    }

    public void ShowData()
    {
        Console.WriteLine("Je me nomme {0}", this.Nom);
        House.ShowData();
    }
}

class TestHouse
{
    static void Main()
    {
        bool debug = true;

        SmallApartment mySmallApartament = new SmallApartment();
        Person myPerson = new Person();

        myPerson.SetNom("Yann");
        myPerson.SetHouse(mySmallApartament);
        myPerson.ShowData();

        if (debug)
            Console.ReadLine();
    }
}
// FIN EXERCICE 2 --

// EXERCICE 3 --
class Encrypter
{
    public static string Encrypt(string chaine)
    {
        char[] chaineCryptee = new char[chaine.Length];
        for (int i = 0; i < chaine.Length; i++)
        {
            chaineCryptee[i] = (Char)(Convert.ToUInt16(chaine[i]) + 1);
        }

        chaine = new string(chaineCryptee);

        return chaine;
    }

    public static string Decrypt(string chaine)
    {
        char[] chaineDecryptee = new char[chaine.Length];
        for (int i = 0; i < chaine.Length; i++)
        {
            chaineDecryptee[i] = (Char)(Convert.ToUInt16(chaine[i]) - 1);
        }

        chaine = new string(chaineDecryptee);

        return chaine;
    }
}

class Crypt
{
    static void Main()
    {
        string newText = Encrypter.Encrypt("Hola");
        Console.WriteLine(newText);
        newText = Encrypter.Decrypt(newText);
        Console.WriteLine(newText);
        Console.ReadLine();
    }
}
// FIN EXERCICE 3 --
