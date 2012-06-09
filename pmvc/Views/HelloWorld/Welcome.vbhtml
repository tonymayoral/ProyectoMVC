@Code
    ViewData("Title") = "Welcome"
End Code

<h2>Welcome</h2>

<ul> 

@For i = 0 To ViewBag.NumTimes
    @:<li>@ViewBag.Message</li>
Next

</ul>
