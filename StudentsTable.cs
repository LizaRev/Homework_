class StudentsTable
{
    private Student[] students;  
    private int size;

    public StudentsTable(int size)
    {  
        this.size = size;
        students = new Student[size]; 
    }

    public Student this[int index]
    {
        get
        {
            if (index >= 0 && index < size)
                return students[index];
            else
                return null!;
        }
        set
        {
            if (index >= 0 && index < size)
                students[index] = value;
        }
    }

    public int Count
    {
        get
        {
            return size;
        }
    }
}