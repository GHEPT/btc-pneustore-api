namespace ApiPneuStore.API
{
    public class APIResponse<T>
    {
        public bool Succeed { get; set; }
      
        public string Message { get; set; }
        
        public T Results { get; set; }

    }
}
