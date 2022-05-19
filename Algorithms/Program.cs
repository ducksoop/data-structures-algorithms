using Algorithms;

var customersList = new List<Customer>()
{
    new() {Age = 3, Name = "Ann"},
    new() {Age = 16, Name = "Bill"},
    new() {Age = 12, Name = "Rosa"},
    new() {Age = 31, Name = "Dan"},
    new() {Age = 16, Name = "Stan"},
    new() {Age = 21, Name = "John"},
};

var intList = new List<int>() {1, 4, 2, 7, 5, 9, 12, 3, 2, 1};

var contains = intList.Contains(0);
var contains2 = customersList.Contains(new Customer {Age = 3, Name = "Ann"}, new CustomersComparer());

var exists = customersList.Exists(customer => customer.Age == 21);

var min = intList.Min();
var max = intList.Max();

var youngestCustomer = customersList.Min(customer => customer.Age);


var bill = customersList.Find(customer => customer.Name == "Bill");
var lastBill = customersList.FindLast(customer => customer.Name == "Bill");
var lastBill2 = customersList.Last(customer => customer.Name == "Bill");

var customers = customersList.FindAll(customer => customer.Age > 18);
var whereAge = customersList.Where(customer => customer.Age > 18);

var index1 = customersList.FindIndex(customer => customer.Age == 14);
var lastIndex = customersList.FindLastIndex(customer => customer.Age > 18);

var indexOf = intList.IndexOf(2);
var lastIndexOf = intList.LastIndexOf(2);

// from list
var isTrueForAll = customersList.TrueForAll(customer => customer.Age > 10);

// from linq
var all = customersList.All(customer => customer.Age > 18);

var areThereAny = customersList.Any(customer => customer.Age == 3);

var count = customersList.Count(customer => customer.Age > 18);

var firstBill = customersList.First(customer => customer.Name == "Bill");

var singleAnn = customersList.Single(customer => customer.Name == "Ann");

static bool Exists(int[] array, int number)
{
    for (var i = 0; i < array.Length; i++) 
    {
        if (array[i] == number)
            return true;
    }

    return false;
}

static int IndexOf(int[] array, int number)
{
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
            return i;
    }

    return -1;
}

public class CustomersComparer : IEqualityComparer<Customer>
{
    public bool Equals(Customer? x, Customer? y)
    {
        return x.Age == y.Age && x.Name == y.Name;
    }

    public int GetHashCode(Customer obj)
    {
        return obj.GetHashCode();
    }
}