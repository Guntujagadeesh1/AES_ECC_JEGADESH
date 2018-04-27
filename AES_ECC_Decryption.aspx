<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="AES_ECC_Decryption.aspx.cs" Inherits="AES_ECC_JEGADESH.AES_ECC_Decryption" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">




        <div class="row">
            <div class="col-md-12">
                <h1>
                    <u>
                        <asp:Label ID="Label2" runat="server" Text="AES ECC Decryption" Style="font-weight: 700; font-size: larger;"></asp:Label></u></h1>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4">
                <div class="form-group">
                    <asp:FileUpload ID="FileUploadControl" runat="server" OnLoad="FileUpload1_Load" OnDataBinding="FileUploadControl_DataBinding"></asp:FileUpload>
                    <asp:Button ID="Button5" class="btn btn-danger btn-sm" runat="server" Text="Upload" OnClick="Button5_Click" />
                </div>
            </div>
            <div class="col-md-4">
                <div class="form-group">
                    <asp:Label ID="Label6" runat="server" Text="Encrypted Key" Style="font-weight: 700; font-size: larger;"></asp:Label>
                    <asp:TextBox ID="TextBox1" CssClass="form-control" placeholder="key....." runat="server"></asp:TextBox>

                </div>
            </div>
            <div class="col-md-4">
                <div class="col-md-6">
                    <div class="form-group">
                        <asp:Label ID="Label8" runat="server" Text="D Value" Style="font-weight: 700; font-size: larger;"></asp:Label>
                        <asp:TextBox ID="txtdvalue" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-6" style="background-color: cyan">
                    <asp:Label ID="Label9" runat="server" Text="" Style="font-weight: 700; font-size: larger;"></asp:Label>
                    <asp:Button ID="Button7" class="btn btn-danger btn-md" runat="server" Text="KEY ECC Decryption" OnClick="Button7_Click" />



                </div>
            </div>


        </div>

        <div class="row" style="background-color: powderblue">
            <div class="col-md-4">
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Cipher Text" Style="font-weight: 700; font-size: larger;"></asp:Label>
                    <asp:TextBox ID="txtcipher" CssClass="form-control" TextMode="MultiLine" Height="150" runat="server"></asp:TextBox>
                    <asp:FileUpload ID="FileUpload1" runat="server" OnLoad="FileUpload1_Load" OnDataBinding="FileUploadControl_DataBinding"></asp:FileUpload>
                    <asp:Button ID="Button8" class="btn btn-danger btn-sm" runat="server" Text="Upload" OnClick="Button8_Click" />
                </div>
            </div>
            <div class="col-md-4">
                <div class="form-group text-center">
                    <br />
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Orginal Key" Style="font-weight: 700; font-size: larger;"></asp:Label>
                    <asp:TextBox ID="TextBox2" CssClass="form-control" placeholder="key....." runat="server"></asp:TextBox><br />
                    <asp:Button ID="Button4" class="btn btn-danger btn-md text-center" runat="server" Text="Decryption" OnClick="Button4_Click" />
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

        

        
    </div>
</asp:Content>
