namespace lap4
{
    public class Person
    {
        
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Person()
        {
            
        }
        public Person(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Phone: {Phone}, Email: {Email}";
        }
    }
}