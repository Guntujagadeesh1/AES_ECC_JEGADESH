<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="AES_ECC_Encryption.aspx.cs" Inherits="AES_ECC_JEGADESH.AES_ECC_Encryption" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <h1>
                    <u>
                        <asp:Label ID="Label2" runat="server" Text="AES ECC Encryption" Style="font-weight: 700; font-size: larger;"></asp:Label></u></h1>
            </div>
        </div>
        <div class="row" style="background-color: powderblue">
            <div class="col-md-4">
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Plain Text" Style="font-weight: 700; font-size: larger;"></asp:Label>
                    <asp:TextBox ID="txtplain" CssClass="form-control" TextMode="MultiLine" Height="150" runat="server"></asp:TextBox>
                    <asp:FileUpload ID="FileUploadControl" runat="server" OnLoad="FileUpload1_Load" OnDataBinding="FileUploadControl_DataBinding"></asp:FileUpload>
                    <asp:Button ID="Button5" class="btn btn-danger btn-sm" runat="server" Text="Upload" OnClick="Button5_Click" />
                     <asp:Label ID="Label41" runat="server" Text="" Style="font-weight: 700; font-size: larger;"></asp:Label>
                   
                </div>
            </div>
            <div class="col-md-4">
                <div class="form-group text-center">
                    <br />
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Orginal Key" Style="font-weight: 700; font-size: larger;"></asp:Label>
                    <asp:TextBox ID="TextBox2" CssClass="form-control" placeholder="key....." runat="server"></asp:TextBox><br />
                    <asp:Button ID="Button4" class="btn btn-danger btn-md text-center" runat="server" Text="Encryption" OnClick="Button4_Click" />
                </div>
            </div>
            <div class="col-md-4 ">
                <div class="form-group">
                    <asp:Label ID="Label7" runat="server" Text="Cipher Text" Style="font-weight: 700; font-size: larger;"></asp:Label>
                    <asp:TextBox ID="TextBox6" CssClass="form-control" TextMode="MultiLine" Height="150" runat="server"></asp:TextBox>
                    <br />
                    <asp:Button ID="Button6" class="btn btn-danger btn-sm" runat="server" Text="SAVE" OnClick="Button6_Click" />
                </div>
            </div>
        </div>
        <br /><br />
        <div class="row">

        </div>
         <div class="row">

        </div>
        <div class="row">
            <div class="col-md-4">
                <div class="col-md-6">
                    <div class="form-group">
                        <asp:Label ID="Label6" runat="server" Text="D Value" Style="font-weight: 700; font-size: larger;"></asp:Label>
                        <asp:TextBox ID="txtdvalue" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-6" style="background-color: cyan">
                    <asp:Label ID="Label8" runat="server" Text="Point" Style="font-weight: 700; font-size: larger;"></asp:Label>
                    <table>
                        <tr>
                            <td>
                                <asp:TextBox ID="txtX" CssClass="form-control" placeholder="x" runat="server"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txtY" CssClass="form-control" placeholder="y" runat="server"></asp:TextBox></td>
                        </tr>
                    </table>


                </div>
            </div>


            <div class="col-md-4 text-center">
                <div class="form-group">
                    <br />
                    <asp:Button ID="Button1" class="btn btn-danger btn-md" runat="server" Text="KEY ECC Encryption" OnClick="Button1_Click" />
                </div>
            </div>

            <div class="col-md-3">
                <div class="form-group">
                    <asp:Label ID="Label4" runat="server" Text="Encrypted Key" Style="font-weight: 700; font-size: larger;"></asp:Label>
                    <asp:TextBox ID="TextBox3" CssClass="form-control" placeholder="key....." runat="server"></asp:TextBox>

                </div>
            </div>
            <div class="col-md-1">
                <div class="form-group">
                    <br />
                    <asp:Button ID="Button2" class="btn btn-danger btn-md" runat="server" Text="Save KEY" OnClick="Button2_Click" />
                </div>
            </div>
        </div>

      
    </div>
    <br />
    <br />
    
</asp:Content>
