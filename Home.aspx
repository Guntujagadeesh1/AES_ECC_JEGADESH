<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="AES_ECC_JEGADESH.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row col-md-12">
            <h2>Abstract</h2>

            <p>

                Data security has a major role in the development of communication system, where more randomization in the secret keys increases the security as well as the complexity of the cryptography algorithms. The Advanced Encryption Standard is a strong symmetric key cryptographic algorithm which uses a number of table look ups to increase its performance. In this project, an extension of a public-key cryptosystem is proposed to support a private key cryptosystem which is a combination of Advanced Encryption Standard with 12 rounds and simple ECC algorithm. The message is encrypted with AES having 12 rounds which results in a cipher which is an input for the simple ECC algorithm which results in final cipher. This resultant cipher is decrypted using AES algorithm. Hence, the complexity is increased which minimizes the various attacks. 

            </p>
        </div>
    </div>
</asp:Content>
