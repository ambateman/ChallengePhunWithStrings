<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ChallengePhunWithStrings._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            1) Reverse Name:
            <asp:Label ID="lblReverseName" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp; --&nbsp; (Original:
            <asp:Label ID="lblOrginalName" runat="server"></asp:Label>
            )</p>
        <p>
            2.) Reverse Sequence:&nbsp;
            <asp:Label ID="lblSequenceReversed" runat="server"></asp:Label>
        </p>
        <p>
            3) ASCII Art:
        </p>
        <p>
&nbsp;<asp:Label ID="lblAsciiArt" runat="server"></asp:Label>
        </p>
        <p>
            4) Puzzle String:
            <asp:Label ID="lblPuzzle" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
