namespace CameYA.Api.Responses
{
    public class GenericResponse<T>
    {
        public GenericResponse(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
    }
}
