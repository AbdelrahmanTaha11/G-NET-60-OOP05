namespace G_NET_60_OOP_5;

internal class Program
{
    static void Main(string[] args)
    {
        #region Part01
        #region Question01
        /*
         Q1 : What is an interface in C#? Why do we use interfaces 
              instead of depending on concrete classes directly?
              Mention at least three benefits of using interfaces.


            // An interface in C# is a contract that defines a set of methods,
            // properties, or events that a class must implement.
            //
            // We use interfaces instead of depending directly on concrete classes
            // to make the code more flexible and maintainable.
            //
            // Benefits of using interfaces:
            // 1. Loose Coupling: Reduces dependency between classes.
            // 2. Flexibility: Different classes can implement the same interface.
            // 3. Easy Testing: Makes unit testing and mocking easier.
            // 4. Polymorphism: Allows working with different implementations
            //    through a common interface reference.

   
         */



        #endregion

        #region Question02
        //Q2 : Look at the following code and answer the questions below:

        /*// a)
             // The problem is that both interfaces contain a method named Greet().
             // Currently, the Translator class provides only one implementation,
             // so both IEnglishSpeaker.Greet() and IArabicSpeaker.Greet()
             // use the same method and cannot have different behaviors.

        // b)
          // The solution is to use Explicit Interface Implementation.
          //
          // Example:
          // void IEnglishSpeaker.Greet() => Console.WriteLine("Hello");
          // void IArabicSpeaker.Greet() => Console.WriteLine("Ahlan");
          //
          // This technique is called Explicit Interface Implementation.
          // It allows a class to provide separate implementations
          // for members with the same signature from different interfaces.

        // c)
          // No, translator.Greet() cannot be called directly after applying
          // Explicit Interface Implementation because the methods are hidden
          // from the class interface and are only accessible through
          // an interface reference or by casting.
          //
          // Example:
          // ((IEnglishSpeaker)translator).Greet(); // Hello
          // ((IArabicSpeaker)translator).Greet();  // Ahlan*/


        #endregion

        #region Question03
        /*
         Q3 : Explain the difference between a shallow copy and a deep copy.
        When would you use each one?
        What is the risk of using a shallow copy when the object has reference-type fields?
         */

        /*
                            // A shallow copy creates a new object but copies the references
            // of reference-type fields. Both objects share the same referenced data.
            //
            // A deep copy creates a completely independent object and also creates
            // copies of all referenced objects, so changes do not affect the original.
            //
            // Use Shallow Copy when shared referenced data is acceptable
            // and better performance is desired.
            //
            // Use Deep Copy when a fully independent copy of the object is required.
            //
            // Risk of Shallow Copy:
            // If the object contains reference-type fields, modifying the referenced
            // object through one copy will also affect the other copy because both
            // objects point to the same memory location.
                         
         
         */



        #endregion

        #region Question04

        //Q4: Look at the following code and determine the output.Explain why.

        /* Output:
            //
            // Dev - Testing
            // QA - Testing
            
            // Explanation:
            
            // e2 is created using MemberwiseClone(), which performs a Shallow Copy.
            
            // After the copy:
            // - Title is a string (immutable type), so changing e2.Title
            //   does not affect e1.Title.
            // - Dept is a reference-type object (Department), so both e1.Dept
            //   and e2.Dept reference the same Department instance.
            //
            // Therefore:
            // e2.Title = "QA"; affects only e2.
            // e2.Dept.Name = "Testing"; affects the shared Department object,
            // so the change is visible through both e1 and e2.
            
        */
           


        #endregion



        #endregion
    }
}
