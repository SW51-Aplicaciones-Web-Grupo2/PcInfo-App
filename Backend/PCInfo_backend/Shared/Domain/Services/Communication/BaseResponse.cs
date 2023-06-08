﻿namespace PCInfo_backend.Shared.Domain.Services.Communication;

public abstract class BaseResponse<T>
{
    protected BaseResponse(string message)
    {
        Message = message;
    }
    
    protected BaseResponse(T resource)
    {
        Resource = resource;
    }
    
    public bool Success { get; set; }
    public string Message { get; set; }
    public T Resource { get; set; }
    
}