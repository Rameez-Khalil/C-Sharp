/*
 * NAMED PARAMETERS: 
 *      Named parameters, you can sepcify the value of the parameter according to their names and not their order.
 *      public void stringConcat(String s1, String s2, String s3){
 *              return s1+s2+s3; 
 *              }
 *     stringConcat(s1:<string>, s2:<string2>, s3:<string3>
 *      
 * REF PARAMETER: 
 *      This keyword is used for passing the value types by reference.
 *      This is helpful when we want to change the original value.
 *      
 *      
 *      string name = "Dog"
 *      public string changeName(ref string name){
 *          name = "Dog And Cat"; 
 *          return name; 
 *          }
 *          
 *     
 * OUT  Paramter: 
 *      Out parameter is a keyword in C# which is used for passing the arguments to methods as a reference type.
 *      It is generally used when a method returns multiple values.
 *      
 *      int num; 
 *      AddNumber(out int num){
 *          num = 40;
 *          num+=num;
 *          }
 *     //Answer will be 40.
 *     
 * 
 * DYNAMIC PARAMETER: 
 *      Compiler doesn't check the type of the dynamic type variable at compile time.
 *      
 *      public void doSomething(dynamic val){
 *          val*val; 
 *      }
 *      
 *      //we can pass any kind of value when calling this method.
 *      
 *     
 */