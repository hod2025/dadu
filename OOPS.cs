//Function Overloading
/*class Program
{
public void add(int a, int b)
{
Console.WriteLine(a + b);
}
public void add(float x, float y)
{
Console.WriteLine(x + y);
}
public void add(string s1, string s2)
{
Console.WriteLine(s1 + s2);
}
static void Main(string[] args)
{
Program obj = new Program();
obj.add(10, 20);
obj.add(10.5f, 20.5f);
obj.add("pranaya", "kumar");
Console.WriteLine("Press any key to exist.");
Console.ReadKey();
}
}*/
//Function Overriding
/*class Class1
{
public virtual void show()
{
Console.WriteLine("Super class show method");
}
}
class Class2 : Class1
{
public override void show()
{
Console.WriteLine("Sub class override show method");
}
}
class Program
{
static void Main(string[] args)
{
Class2 obj = new Class2();

obj.show();
Console.ReadKey();
}
}*/
//Function Hiding
/*class Class1
{
public void display()
{
Console.WriteLine("Super class display method");
}
}
class Class2 : Class1
{
public new void display()
{
Console.WriteLine("Sub class display method");
}
}
class Program
{
static void Main(string[] args)
{
Class2 obj = new Class2();
obj.display();
Console.ReadKey();
}
}*/
//Encapsulation
/*public class Bank
{
//hiding class data by declaring the variable as private
private double balance;
//creating public setter and getter methods
public double getBalance()
{
//add validation logic if needed
return balance;
}
public void setBalance(double balance)
{
// add validation logic to check whether data is correct or not
this.balance = balance;
}
}
class BankUser
{
public static void Main()
{
Bank SBI = new Bank();
SBI.setBalance(500);
Console.WriteLine(SBI.getBalance());
Console.WriteLine("Press any key to exist.");
Console.ReadKey();
}
}*/

//inheritance
/*class Branch
{
int BranchCode;
string BranchName, BranchAddress;
public void GetBranchData()
{
Console.WriteLine("ENTER BRANCH DETAILS:");
Console.WriteLine("ENTER BRANCH CODE");
BranchCode = int.Parse(Console.ReadLine());
Console.WriteLine("ENTER BRANCH NAME");
BranchName = Console.ReadLine();
Console.WriteLine("ENTER BRANCH ADDRESS");
BranchAddress = Console.ReadLine();
}
public void DisplayBranchData()
{
Console.WriteLine("BRANCH CODE IS : " + BranchCode);
Console.WriteLine("BRANCH NAME IS : " + BranchName);
Console.WriteLine("BRANCH ADDRESS IS : " + BranchAddress);
}
}
class Employee : Branch
{
int EmployeeId, EmployeeAge;
string EmployeeName, EmployeeAddress;
public void GetEmployeeData()
{
Console.WriteLine("ENTER EMPLYEE DETAILS:");
Console.WriteLine("ENTER EMPLOYEE ID");
EmployeeId = int.Parse(Console.ReadLine());
Console.WriteLine("ENTER EMPLOYEE AGE");
EmployeeAge = int.Parse(Console.ReadLine());
Console.WriteLine("ENTER EMPLOYEE NAME");
EmployeeName = Console.ReadLine();
Console.WriteLine("ENTER EMPLOYEE ADDRESS");
EmployeeAddress = Console.ReadLine();
}
public void DisplayEmployeeData()
{
Console.WriteLine("EMPLOYEE ID IS : " + EmployeeId);
Console.WriteLine("EMPLOYEE NAME IS : " + EmployeeName);
Console.WriteLine("EMPLOYEE ADDRESS IS : " + EmployeeAddress);
Console.WriteLine("EMPLOYEE AGE IS : " + EmployeeAge);
}
}
class Program
{
static void Main(string[] args)
{
Employee obj1 = new Employee();
obj1.GetBranchData();
obj1.GetEmployeeData();
obj1.DisplayBranchData();
obj1.DisplayEmployeeData();
Console.WriteLine("Press any key to exist.");
Console.ReadKey();

}
}*/
//interface inheritance
/*public interface A
{
void method1();
void method2();
}
interface B : A
{
void method3();
}
class MyClass : B
{
public void method1()
{
Console.WriteLine("implement method1");
}
public void method2()
{
Console.WriteLine("implement method2");
}
public void method3()
{
Console.WriteLine("implement method3");
}
}
class Program
{
static void Main(string[] args)
{
MyClass obj = new MyClass();
obj.method1();
obj.method2();
obj.method3();
Console.WriteLine("Press any key to exist.");
Console.ReadKey();
}
}*/
//Abstract classes/methods
/*public abstract class MyClass
{
public abstract void calculate(double x);
public void show()
{
Console.WriteLine("Show");
}
}
class Sub1 : MyClass
{
public override void calculate(double x)
{
Console.WriteLine("SQUARE ROOT IS " + Math.Sqrt(x));
}
}
class Test
{

static void Main(string[] args)
{
Sub1 obj1 = new Sub1();
obj1.calculate(9);
obj1.show();
Console.ReadKey();
}
}*/
//Collection Classes Stack, Queue, LinkedList, SortedList, ArrayList, HashTable, etc.
/*class Program
{
static void Main(string[] args)
{
//Createing ArrayList collection using default constructor
ArrayList al = new ArrayList();
Console.WriteLine("Initial Capacity: " + al.Capacity);
al.Add(10);
Console.WriteLine("Capacity after adding first item: " + al.Capacity);
al.Add("hello");
al.Add(true);
al.Add(3.14f);
Console.WriteLine("Capacity after adding fourth item: " + al.Capacity);
al.Add('A');
Console.WriteLine("Capacity after adding 5th element: " + al.Capacity);
//Printing the ArrayList elements using for loop
for (int i = 0; i < al.Count; i++)
{
Console.Write(al[i] + " ");
}
Console.WriteLine();
//Removing the values from the middle of the array list
//here we are removing by value
al.Remove(true);
//You can also remove element by using index position
// al.RemoveAt(2);
//Printing the ArrayList elements using foreach loop after
// removing an element from the collection
foreach (object obj in al)
{
Console.Write(obj + " ");
}
Console.WriteLine();
//inserting values into the middle of the array list collection
al.Insert(2, false);
// Printing the values of the collection using foreach loop after
// inserting an element into the middle of the collection
foreach (object obj in al)
{
Console.Write(obj + " ");
}
Console.WriteLine();
// creating new ArrayList collection by passing the old
// array list as parameter

ArrayList coll = new ArrayList(al);
Console.WriteLine("Initial capacity of new array list collection:" + coll.Capacity);
// Printing the values of the new array list collection using foreach loop
foreach (object obj in coll)
{
Console.Write(obj + " ");
}
Console.ReadKey();
}
}*/
//Properties
public class Example
{
private int _empid, _eage;
private string _ename, _eaddress;
public int empid
{
set
{
_empid = value;
}
get
{
return _empid;
}
}
public int eage
{
set
{
_eage = value;
}
get
{
return _eage;
}
}
public string ename
{
set
{
_ename = value;
}
get
{
return _ename;
}
}
public string eaddress
{
set
{
_eaddress = value;
}
get
9
{
return _eaddress;
}
}
}
class Program
{
static void Main(string[] args)
{
Example obj1 = new Example();
obj1.empid = 101;
obj1.ename = "abc";
obj1.eage = 27;
obj1.eaddress = "shirpur";
Console.WriteLine("Employee details are:");
Console.WriteLine("employee id:" + obj1.empid);
Console.WriteLine("employee name:" + obj1.ename);
Console.WriteLine("employee age:" + obj1.eage);
Console.WriteLine("employee address:" + obj1.eaddress);
Console.ReadKey();
}
}