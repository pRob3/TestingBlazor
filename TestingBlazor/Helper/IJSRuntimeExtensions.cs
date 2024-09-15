﻿using Microsoft.JSInterop;

namespace TestingBlazor.Helper;

public static class IJSRuntimeExtensions
{
    public static async Task ToastrSuccess(this IJSRuntime js, string message)
    {
        await js.InvokeVoidAsync("showToastr", "success", message);
    }

    public static async Task ToastrError(this IJSRuntime js, string message)
    {
        await js.InvokeVoidAsync("showToastr", "error", message);
    }
}
