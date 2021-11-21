using hw_1;
    
Person person = new Person();
person.Hello(); 

Student student = new Student();
student.SetAge(21);
student.Hello();

Teacher teacher = new Teacher("wewe");
teacher.SetAge(30);
teacher.Hello();
teacher.Explain();
