namespace Domain
{
    public class Member
    {

        public int Id {get; set;}
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }    

        public string  PhoneNumber { get; set; }    
        public string Email { get; set; }

      //  public string MaritalStatus { get; set; }

        public DateTime Date { get; set; }
      //  public List<string> FamilyMembers { get; set; }
        
    }
}