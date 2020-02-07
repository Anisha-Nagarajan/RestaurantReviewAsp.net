<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.Master" CodeBehind="Login.aspx.cs" Inherits="RestaurantReviewWeb.Login" %>

<asp:Content ID="contentHead" runat="server" ContentPlaceHolderID="head">
    </asp:Content>
        <asp:Content ID="contentPlaceHolderLogin" ContentPlaceHolderID="ContentPlaceHolder" runat="server">

            <section>
                <h1 style="text-align:center">
                    Login
                </h1>
             
            </section>
            <table align="Center">
                <tr>
                    <td>UserName :</td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>

                    </td>

                </tr>
                <tr>
                    <td>Password :</td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td align="Left" class="auto-style1">
                        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="Button1_Click" />
                    </td>
                    <td align="Right">

                        <asp:Button ID="btnSignUp" runat="server" Text="SignUp" OnClick="Button2_Click" style="height: 26px" />
                    </td>
                    
                </tr>
            </table>
            </asp:Content>