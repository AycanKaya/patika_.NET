namespace TodoApp
{
    class Program {
         

    }

    class Team{
      public string team_name;
      public List<Person> teamMembers;
      public Team(string team_name){
        teamMembers=new List<Person>();
        this.team_name=team_name;
      }

      public  void addPerson(Person person){
        teamMembers.Add(person);
      }
      public List<Person> TeamMembers   // property
         {
             get { return teamMembers; }   // get method
             
        }

        public async void writeAllMembers(){
          int i = 1;
          foreach(var pers in teamMembers){
            Console.WriteLine(i+") Name : "+pers.name+" Surname : "+pers.surname);
            i++;
          }
        }

        public  Person findPerson(string name, string surname){
            foreach(var i in teamMembers){
              if(i.name.Equals(name) && i.surname.Equals(surname)){
                return i;
              }
            }
            return null;
        }
    

    }

    class Person{
      public string name;
      public string surname ;
      public Team team;
      public Person(string name,string surname, Team  team){
        this.name=name;
        this.surname=surname;
        this.team=team;
      }
      


    }
    enum  Magnitude{
      XS ,     
       S ,
      M ,
      L,
      XL

     
    }
    

    class Board{
     
      public Team team;
      public List<Card> Cards;
      public List<Card> Progress;
      public List<Card> Done;
      public Board(Team team){
        team=team;
              Cards=new List<Card>();
        Progress=new List<Card>();
        Done=new List<Card>();

      }
      public void addCard(){

        Console.WriteLine("Başlık giriniz : ");
        string header = Console.ReadLine();
        Console.WriteLine("İçerik  giriniz : ");
        string content = Console.ReadLine();
        Console.WriteLine("Bütüklük Seçiniz : ");
        string mag = Console.ReadLine();
        Console.WriteLine("Kişi Seçiniz : ");
        team.writeAllMembers();
        string name = Console.ReadLine();
        string  surname = Console.ReadLine();
        Person p =team.findPerson(name,surname);

        
        Card card = new Card(header,content,p,"",Magnitude.mag);




        Cards.Add(card);
        if(card.line == "progress")
          Progress.Add(card);
        if(card.line == "done")
          Done.Add(card);

        Console.WriteLine("Adding operations is successfull.");
      }
      public void deleteCard(Card  card){
        if(Cards.Contains(card))
           Cards.Remove(card);
        if(Progress.Contains(card))
           Progress.Remove(card);
        if(Done.Contains(card))
           Done.Remove(card);
           
          Console.WriteLine("Delete operation is successfull.");       
      }

      public void listingTODO(){
        Console.WriteLine(" TODO Line ");
        Console.WriteLine(" ************************");
        foreach(var card in Cards){
          Console.WriteLine("Başlık : "+ card.header+"\n"+
                    "İçerik : "+card.content+"\n"+
                    "Atanan Kişi : "+card.person.name+" "+card.person.surname+"\n"+
                    "Büyüklük : "+card.M
          
          );
        }
      }
      public void listingProgress(){
        Console.WriteLine(" IN PROGRESS Line ");
        Console.WriteLine(" ************************");
        foreach(var card in Progress){
           Console.WriteLine("Başlık : "+ card.header+"\n"+
                    "İçerik : "+card.content+"\n"+
                    "Atanan Kişi : "+card.person.name+" "+card.person.surname+"\n"+
                    "Büyüklük : "+card.M
          
          );
        }
      }
       public void listingDone(){
        Console.WriteLine(" DONE Line ");
        Console.WriteLine(" ************************");
        foreach(var card in Done){
           Console.WriteLine("Başlık : "+ card.header+"\n"+
                    "İçerik : "+card.content+"\n"+
                    "Atanan Kişi : "+card.person.name+" "+card.person.surname+"\n"+
                    "Büyüklük : "+card.M
          
          );
        }
      }



    }
    class Card{
        public string header;
        public string content;
        public Person person;
        public Magnitude M;
        public string line;
      

        public Card(string header, string content, Person person,string line,Magnitude  m){
          this.header=header;
          this.content=content;
          this.person=person;
          this.line=line;
          this.M=m;
        }
        


    
    
      }




}