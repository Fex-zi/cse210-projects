using System;

public class MathAssignment : Assignment
{
    private string _homeworkList;

    public MathAssignment(string studentName, string topic, string section, string homeworkList) : base(studentName, topic)
    {
        _homeworkList = section + " - " + homeworkList;
    }

    public override string GetSummary()
    {
        return base.GetStudentName() + " - " + base.GetTopic() + " - " + _homeworkList;
    }
}
