using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        if (id == null && department != null)
        {
            return $"{name} - {department.ToUpper()}";
        } 
        
        else if (department == null)
        {
            if (id == null)
            {
                return $"{name} - OWNER";
            }
            else
            {
                return $"[{id}] - {name} - OWNER";
            }
        }
        else
        {
            return $"[{id}] - {name} - {department.ToUpper()}";
        }
    }
}
