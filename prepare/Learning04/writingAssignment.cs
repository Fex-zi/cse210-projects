using System;


public class WritingAssignment : Assignment
{
    private string _writingInformation;

    public WritingAssignment(string studentName, string topic, string writingInformation) : base(studentName, topic)
    {
        _writingInformation = writingInformation;
    }

    public new string GetSummary()
    {
        return base.GetStudentName() + " - " + base.GetTopic() + " - " + _writingInformation;
    }
}
