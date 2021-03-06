namespace ToDo.IntegrationTests.Helpers
{
    public static class RefreshToken
    {
        /// <summary>
        ///     Valid refresh token with user id = 1
        /// </summary>
        public const string Valid =
            "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwibmJmIjoxNjMxNzE4MzY5LCJleHAiOjE3MzE3MTkyNjksImlhdCI6MTYzMTcxODM2OX0.r65nyQPEFftc5DFwb-mb8iz7VpEXnNQ5zOlrAOyqw-Uoxz722Bq62bqyyfaQwy8caGBXsDJnGAuPHheKClewxQ";

        /// <summary>
        ///     Invalid refresh token
        /// </summary>
        public const string Invalid = "invalid";
    }
}