using StorageProject;

Storage<int> intStorage = new Storage<int>(5);
Console.WriteLine(intStorage);

intStorage.SetData(10);
Console.WriteLine(intStorage);

Storage<Student> studentStorage = new Storage<Student>(new Student 
    {
        Name="lukrécia",
        Age=17
    }
);
Console.WriteLine(studentStorage);