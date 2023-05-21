class Vehicle
{
  private string number;
  private string color;
  private string type;
  private DateTime dateTime;
  public Vehicle(string number, string color, string type, DateTime dateTime) {
      this.number = number;
      this.color = color;
      this.type = type;
      this.dateTime = dateTime;
  }
  public string Number {
    get { return number; }   
    set { number = value; }  
  }
  public string Color {
    get { return color; }   
    set { color = value; }  
  }
  public string Type{
    get { return type; }   
    set { type = value; }  
  }
  public DateTime DateTime{
    get { return dateTime; }   
    set { dateTime = value; }  
  }
  
}


// class Mobil : Vehicle
// {
//   public Mobil(String number, String color) : base(number,color){
    
//   }
// }

// class Motor : Vehicle
// {
//   public Motor(String number, String color) : base(number,color){
    
//   }
// }