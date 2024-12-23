﻿namespace Common
{
    public interface IAuthorizerContext
    {
        Authorizer Current { get; }

        void Refresh();
    }
}