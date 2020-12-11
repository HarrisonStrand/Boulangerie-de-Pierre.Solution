namespace ProjectName
{
  public class ClassName
  {
    private string _myField;
    // ^ this is a field. It is private to your class and stores the actual data.

    public string MyProperty
    {
      get
      {
        return _myField;
      }
      set
      {
        _myField = value;
      }
    // this is a property. When accessed it uses the underlying field,
    // but only exposes the contract, which will not be affected by the underlying field

    }

    public int AnotherProperty{get;set;}
    // This is an AutoProperty (C# 3.0 and higher) - which is a shorthand syntax
    // used to generate a private field for you
    }
  }


//It's worth noting that properties are not required to encapsulate fields. There could be no field at all behind the property. It might be a calculation or return a constant or whatever.