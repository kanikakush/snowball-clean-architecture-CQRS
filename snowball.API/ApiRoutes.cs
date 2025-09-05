namespace snowball.API
{
    public class ApiRoutes
    {
        public const string BaseRoute = "api/v{version:apiVersion}";
        public class UserProfiles
        {
            public const string GetAllProfiles = BaseRoute + "/userprofiles/getAll";
            public const string GetById = BaseRoute + "/userprofiles/GetById/{id}";
            public const string Create = BaseRoute + "/userprofiles/Create";
            public const string Update = BaseRoute + "/userprofiles/Update/{id}";
            public const string Delete = BaseRoute + "/userprofiles/Delete/{id}";
        }
        public class Posts
        {
            public const string GetById = BaseRoute + "/{id}";
            public const string Create = BaseRoute + "/posts";
            public const string Update = BaseRoute + "/posts/{id}";
            public const string Delete = BaseRoute + "/posts/{id}";
            public const string Like = BaseRoute + "/posts/{id}/like";
            public const string Unlike = BaseRoute + "/posts/{id}/unlike";
        }
    }
}
