using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Buffers;
using System.Text;

[Route("api")]
public class TestPost : ControllerBase
{
    [HttpGet]
    public string OnGet()
    {
        var str = "{\"version\":\"1.1\",\"method\":\"payment\",\"params\":{\"user\":\"cashier\"}}";
        var req = JsonConvert.DeserializeObject<TestPostConnect.Model.Request>(str);
        return "OnGet";
    }
    
    [HttpPost]
    public async Task<string> PostAsync()
    {
        //++ получаем текст запроса
        var requestBody = Request.Body;
        StringBuilder builder = new();
        byte[] buffer = ArrayPool<byte>.Shared.Rent(4096);
        while (true)
        {
            var bytesRemaining = await requestBody.ReadAsync(buffer, offset: 0, buffer.Length);
            if (bytesRemaining == 0) break;
            var encodedString = Encoding.UTF8.GetString(buffer, 0, bytesRemaining);
            builder.Append(encodedString);
        }
        ArrayPool<byte>.Shared.Return(buffer);
        string entireRequestBody = builder.ToString();
        //--
        var req = JsonConvert.DeserializeObject<TestPostConnect.Model.Request>(entireRequestBody);
        if (req == null) return "{\"error\":\"bad request\"}";
        TestPostConnect.Model.Answer  ansver = new(req);
        return JsonConvert.SerializeObject(ansver);
    }
}