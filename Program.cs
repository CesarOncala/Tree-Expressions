using System.Dynamic;
using System.Linq.Expressions;
using System.Reflection;

class Animal
{
    public double Tamanho { get; set; }
    public string Nome { get; set; }
    public string NomeCientifico { get; set; }

    public string Tipo { get; set; }

    public string Dieta { get; set; }

}


class Program
{

    static void Main(string[] args)
    {
        #region  [Simple Expression Tree]
        // var x = Expression.Parameter(typeof(Animal), "x");
        // var y = Expression.Parameter(typeof(Animal), "y");
        // var parameters = new ParameterExpression[] { x, y };
        // var body = Expression.Equal(x, y);

        // var result = Expression.Lambda<Func<Animal, Animal, bool>>(body, parameters).Compile();
        #endregion

        #region [Expression Tree Invoke Method]
        // var instance = Expression.Parameter(typeof(Animal));
        // var setMethod = typeof(Animal).GetProperty("Dieta").GetSetMethod();

        // var valueToSet = Expression.Parameter(typeof(object));
        // var parameters = new ParameterExpression[]{valueToSet, Expression.Parameter(typeof(string))};

        // var body = Expression.Call(null,typeof(Program).GetMethod(nameof(teste)),parameters);

        // var result = Expression.Lambda<Action<object,string>>(body,parameters).Compile();

        // var animal = new Animal();

        // result("OvolactoVegetariano: "," casa comigo linda");
        #endregion

        #region [Reflection Get Dynamic SetMethod]

        // var property = typeof(Animal).GetProperty("Dieta");
        // var objSetMethod = property.GetSetMethod();

        // var value = Expression.Parameter(typeof(object));
        // var instaceWithMethod = Expression.Parameter(typeof(Animal));

        // var body = Expression.Call(instaceWithMethod,objSetMethod, Expression
        // .Convert(value,property.PropertyType));

        // var lambda = Expression.Lambda<Action<Animal, object>>(body,instaceWithMethod,value).Compile();

        // var animal = new Animal();
        // lambda(animal,"douglas");

        // System.Console.WriteLine(animal.Dieta);

        #endregion

    }

    public static void teste(object t, string juvenal)
    {
        System.Console.WriteLine(t + juvenal);
    }

    public static void teste2(object t)
    {
        System.Console.WriteLine(t);
    }




}