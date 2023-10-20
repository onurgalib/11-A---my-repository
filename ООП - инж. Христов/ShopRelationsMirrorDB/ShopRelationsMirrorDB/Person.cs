namespace ShopRelationsMirrorDB.Models
{
    public class Person
    {
        public Person(string EGN, string name, int age, string email, string profession)
        {
            EGN = EGN;
            Name = name;
            Age = age;
            Email = email;
            Profession = profession;
        }

        //Id
        public string EGN { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Profession { get; set; }
        public virtual IList<PersonShop> PersonShops { get; set; }

    }
}