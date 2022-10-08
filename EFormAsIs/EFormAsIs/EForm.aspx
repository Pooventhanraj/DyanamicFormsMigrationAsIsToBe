<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EForm.aspx.cs" Inherits="EFormAsIs.EForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Employee Details
            <label>Firstname </label>
            <input type="text" name="firstname" size="15" />
            <br/>
            <br/>
            <label>Middlename: </label>
            <input type="text" name="middlename" size="15" />
            <br/>
            <br/>
            <label>Lastname: </label>
            <input type="text" name="lastname" size="15" />
            <br/>
            <br/>

         <%--   <label>
                Course :  
            </label>
            <select>
                <option value="Course">Course</option>
                <option value="BCA">BCA</option>
                <option value="BBA">BBA</option>
                <option value="B.Tech">B.Tech</option>
                <option value="MBA">MBA</option>
                <option value="MCA">MCA</option>
                <option value="M.Tech">M.Tech</option>
            </select>--%>

            <br/>
            <br/>
            <label>
                Gender :  
            </label>
            <br/>
            <input type="radio" name="male" />
            Male
            <br/>
            <input type="radio" name="female" />
            Female
            <br/>
            <input type="radio" name="other" />
            Other  
            <br/>
            <br/>

            <label>
                Phone :  
            </label>
            <input type="text" name="country code" value="+91" size="2" />
            <input type="text" name="phone" size="10" />
            <br/>
            <br/>
            Address  
            <br/>
            <textarea cols="80" rows="5" value="address" >  </textarea>

            <br/>
            <br/>
            <div id="displayIfPartTime" runat="server">
        <%--    Email:  
            <input type="email" id="email" name="email" />
            <br/>
            <br/>
            <br/>
            Password:  
            <input type="password" id="pass" name="pass" />
            <br/>       
            <br/>
            <br/>--%>
            </div>
      
            <input type="button" value="Submit"/>  
    </div>
    </form>
</body>
</html>
