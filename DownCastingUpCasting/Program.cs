using DownCastingUpCasting;

Student student = new Student("ammu", 101);

// Upcasting Student to Person
Person person = student;
person.Display();

// Downcasting Person back to Student
Student downcastedStudent = (Student)person;
downcastedStudent.ShowStudentInfo();