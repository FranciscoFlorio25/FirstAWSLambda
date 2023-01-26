using Amazon.Lambda.Core;
using AWSLambda1.UseCases.RequestModel;
using AWSLambda1.UseCases.ResponseModel;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AWSLambda1;

public class Function
{
    
    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public async Task<ResponseSaludo> FunctionSaludo(RequestSaludo input, ILambdaContext context)
    {
        var response = new ResponseSaludo();

        try
        {
            response.ErrorCode = 10;
            response.ErrorMessage = "Primer Lambda";
        }
        catch (Exception e) 
        {
            response.ErrorCode = 100;
            response.ErrorMessage = "Internal Error: " + e.Message;
        }
        return response;
    }
}
