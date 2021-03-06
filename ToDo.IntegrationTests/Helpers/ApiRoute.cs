namespace ToDo.IntegrationTests.Helpers
{
    public static class ApiRoute
    {
        public const string ExternalSignUp = "api/auth/external-sign-up";
        public const string LogOut = "api/auth/log-out";
        public const string ExternalLogIn = "api/auth/external-log-in";
        public const string RefreshTokens = "api/auth/refresh-tokens";
        public const string GetCurrentProfile = "api/profiles/current";
        public const string CreateToDo = "api/todos";
        public const string GetAllToDos = "api/todos";
        public const string GetToDoById = "api/todos/";
        public const string UpdateToDo = "api/todos/";
        public const string DeleteToDo = "api/todos/";
    }
}