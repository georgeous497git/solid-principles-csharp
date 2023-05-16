using SingleResponsability;

StudentRepository studentRepository = new();

ExportHelper<Student> exportHelper = new();
exportHelper.Export(studentRepository.GetAll());

Console.WriteLine("Proceso Completado");