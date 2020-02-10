<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.Master" CodeBehind="Register.aspx.cs" Inherits="RestaurantReviewWeb.Register" %>

<asp:Content ID="contentHead" runat="server" ContentPlaceHolderID="head">
    </asp:Content>
        <asp:Content ID="contentPlaceHolderLogin" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
            <section>
                <h1 style="text-align: center">
                    Registration
                </h1>
           
            </section>
            <table align="Center">

                 <tr>
                    <td>Id :</td>
                    <td>
                        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldId" runat="server"
                            ErrorMessage="Id cannot be blank" ControlToValidate="txtId"></asp:RequiredFieldValidator>
                    </td>

                </tr
                <tr>
                    <td>UserName :</td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                            ErrorMessage="Name cannot be blank" ControlToValidate="txtUserName"></asp:RequiredFieldValidator>
                    </td>

                </tr>
                <tr>
                    <td>Password :</td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Password cannot be blank"
                            ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegExp1" runat="server" ErrorMessage="Password length must be between 8 to 10 characters"
                            ControlToValidate="txtPassword" ValidationExpression="^[a-zA-Z0-9'@&#.\s]{8,10}$"></asp:RegularExpressionValidator>

                    </td>

                </tr>
                <tr>
                    <td>ConfirmPassword :</td>
                    <td>
                        <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword"
                            ControlToValidate="txtConfirmPassword" ErrorMessage="Password and confirm password must be same"></asp:CompareValidator>
                    </td>

                </tr>
                 <tr>
                    <td>Role :</td>
                    <td>
                        <asp:TextBox ID="txtRole" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldRole" runat="server"
                            ErrorMessage="Role cannot be blank" ControlToValidate="txtRole"></asp:RequiredFieldValidator>
                    </td>

                </tr
                <tr>
                    <td>Email :</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                            ErrorMessage="Email cannot be blank " ControlToValidate="txtEmail"></asp:RequiredFieldValidator>

                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                            ControlToValidate="txtEmail" ErrorMessage="Enter valid email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>

                </tr>
                <tr>

                    <td>Address :</td>
                    <td>
                        <asp:TextBox ID="txtStreet" PlaceHolder="Street Name" runat="server" OnTextChanged="txtStreet_TextChanged"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="StreetName cannot be blank"
                            ControlToValidate="txtStreet"></asp:RequiredFieldValidator>
                    </td>

                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:TextBox ID="txtCity" PlaceHolder="City" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="City cannot be blank"
                            ControlToValidate="txtCity"></asp:RequiredFieldValidator>
                    </td>

                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:TextBox ID="txtState" PlaceHolder="State" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="State cannot be blank"
                            ControlToValidate="txtState"></asp:RequiredFieldValidator>
                    </td>

                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:TextBox ID="txtPincode" PlaceHolder="Pincode" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Pincode cannot be blank"
                            ControlToValidate="txtPincode"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server"
                            ControlToValidate="txtPincode" ErrorMessage="Pincode must be 6 digit" ValidationExpression="\d{6}"></asp:RegularExpressionValidator>
                    </td>
                    <tr>
                        <td>Country :</td>
                        <td>
                            <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Password cannot be blank"
                                ControlToValidate="txtCountry"></asp:RequiredFieldValidator>
                        </td>

                    </tr>

                </tr>
                <tr>
                    <td>PhoneNumber :</td>
                    <td>
                        <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                            ErrorMessage="Mobile cannot be blank" ControlToValidate="txtPhoneNumber"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"
                            ControlToValidate="txtPhoneNumber" ErrorMessage="Mobile number must be 10 digit" ValidationExpression="[9876]\d{9}"></asp:RegularExpressionValidator>
                    </td>

                </tr>
                <tr>

                    <td align="Right">

                        <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="Button1_Click" />
                    </td>

                </tr>

            </table>
            </asp:Content>