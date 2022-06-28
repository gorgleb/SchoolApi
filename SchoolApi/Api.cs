using DataAccess.Data;
using DataAccess.Models;

namespace SchoolApi;

public static class Api
{
    public static void ConfigureApi(this WebApplication app)
    {
        //All api endpoint mapping
        app.MapGet("/Users", GetStudents);
        app.MapGet("/Users/{id}", GetStudent);
        app.MapPost("/Users", InsertStudent);
        app.MapPut("/Users", UpdateStudent);
        app.MapDelete("/Users", DeleteStudent);
        //app.MapGet("/Users", SelectTheLaggards);
        //app.MapGet("/Users", ChooseTheExcellentStudents);

    }

    private static async Task<IResult> GetStudents(IStudentData data)
    {
        try
        {
            return Results.Ok(await data.GetStudents());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
    private static async Task<IResult> GetStudent(int id, IStudentData data)
    {
        try
        {
            var results = await data.GetStudent(id);
            if (results == null)
            {
                return Results.NotFound();
            }
            return Results.Ok(results);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
    private static async Task<IResult> InsertStudent(StudentModel student, IStudentData data)
    {
        try
        {
            await data.InsertStudent(student);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
    private static async Task<IResult> UpdateStudent(StudentModel student, IStudentData data)
    {
        try
        {
            await data.UpdateStudent(student);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
    private static async Task<IResult> DeleteStudent(int id, IStudentData data)
    {
        try
        {
            await data.DeleteStudent(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
    private static async Task<IResult> ChooseTheExcellentStudents(IStudentData data)
    {
        try
        {
            return Results.Ok(await data.ChooseTheExcellentStudents());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
    private static async Task<IResult> SelectTheLaggards(IStudentData data)
    {
        try
        {
            return Results.Ok(await data.SelectTheLaggards());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
