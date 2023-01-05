<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addtocart.aspx.cs" Inherits="Project_2.addtocart" %>

<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<title>Products</title>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css" />
       <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
       <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
       <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
       <link href="https://fonts.googleapis.com/css?family=Nunito+Sans:300i,400,700&display=swap" rel="stylesheet">
       <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link href="addtocart.css" rel="stylesheet" />
        <div class="navbarnavbar-default">
    <div class="container-fluid">
        <div class="navbar-header">
            <a href="#" class="navbar-brand">Luffy Shop</a>
        </div>
    </div>
    <div class="collapse navbar-collapse">
        <ul class="nav navbar-nav">
            <li><a href="http://localhost:4200/Home"><span class="glyphicon glyphicon-home"></span>Home</a></li>
            <li><a href="http://localhost:4200/product"><span class="glyphicon glyphicon-th-list"></span>Product</a></li>
            <li><a href="https://localhost:44348/Customer/Login"><span class="glyphicon glyphicon-log-in"></span>Log out</a></li>
        </ul>
        <ul class="nav navbar-nav" style="float: right">
            <li><a href="https://localhost:44348/addtocart.aspx"><span class="glyphicon glyphicon-shopping-cart"></span>Cart</a></li>
        </ul>
    </div>
</div> 
</head>
<body>


<div class="gallery">
    <div class="content">
        <img src="https://projectstorage444.blob.core.windows.net/image/shoes.png">
        <h3 class="productname">Puma Shoes</h3>
        <p>Kids White & Black X-Ray Jr Sneakers</p>
        <h6 class="price">$42.45</h6>
        <button class="addtocart">Add To Cart</button>
</div>
<div id="alerts"></div>
    <div class="content">
        <img src="https://projectstorage444.blob.core.windows.net/image/earphone.png">
        <h3 class="productname">Sony Earphone</h3>
        <p>TSONY MDR-XB55AP/LQIN Wired Earphone with Mic (In Ear, Blue)</p>
        <h6 class="price">$25.42</h6>
        <button class="addtocart">Add To Cart</button>
</div>
<div id="alerts"></div>
    <div class="content">
        <img src="https://projectstorage444.blob.core.windows.net/image/watch.png">
        <h3 class="productname">Nosie Watch</h3>
        <p>NoiseFit Agile 2 Buzz</p>
        <h6 class="price">$30.32</h6>
        <button class="addtocart">Add To Cart</button>
</div>
<div id="alerts"></div>
    <div class="content">
        <img src="https://projectstorage444.blob.core.windows.net/image/headphone.jpg">
        <h3 class="productname">Sony Headphones</h3>
        <p>Sony Wh-Ch510 Bluetooth Wireless On Ear Headphones</p>
        <h6 class="price">$24.25</h6>
        <button class="addtocart">Add To Cart</button>
</div>
<div id="alerts"></div>
    <div class="content">
        <img src="https://projectstorage444.blob.core.windows.net/image/powerbank.png">
        <h3 class="productname">Realme Powerbank</h3>
        <p>Realme 10000 mAh Power Bank</p>
        <h6 class="price">$20.91</h6>
        <button class="addtocart">Add To Cart</button>
</div>
<div id="alerts"></div>
    <div class="content">
        <img src="https://projectstorage444.blob.core.windows.net/image/bulb.png">
        <h3 class="productname">Philips LED bulb</h3>
        <p>NoiseFit Agile 2 BuzzPHILIPS 7W B22D Led Cool Day Light Bulb</p>
        <h6 class="price">$4.52</h6>
        <button class="addtocart">Add To Cart</button>
</div>
<div id="alerts"></div>
<div class="content">
        <img src="https://projectstorage444.blob.core.windows.net/image/jars.jpg">
        <h3 class="productname">Spice Storage Jars Pack-6</h3>
        <p>AARAV HOUSE - 500 Ml Ball Mason Glass Jar</p>
        <h6 class="price">$6.05</h6>
        <button class="addtocart">Add To Cart</button>
</div>
<div id="alerts"></div>
    <div class="content">
        <img src="https://projectstorage444.blob.core.windows.net/image/shamppo.jpg">
        <h3 class="productname">L'Oréal Shampoo</h3>
        <p>L'Oréal Professionnel Absolut Repair Shampoo</p>
        <h6 class="price">$8.34</h6>
        <button class="addtocart">Add To Cart</button>
</div>
<div id="alerts"></div>
    <div class="content">
        <img src="https://projectstorage444.blob.core.windows.net/image/sanks.jpg">
        <h3 class="productname">Haldiram's Nagpur Bhujia Sev,400g</h3>
        <p>Haldiram's Nagpur Bhujia Sev,400g, Brand Haldiram's Nagpur</p>
        <h6 class="price">$1.27</h6>
        <button class="addtocart">Add To Cart</button>
</div>
<div id="alerts"></div>
    </div>
<div>
        <h2>Cart</h2>
            <table id="table">
            <thead>
                <tr>
                    <th><strong>Product</strong></th>
                    <th><strong>Price</strong></th>
                </tr>
            </thead>
            <tbody id="carttable">
            </tbody>
            </table>
        <hr>
    <table class="table" id="carttotals">
    <tr>
        <td><strong>Quantity</strong></td>
        <td><strong>Total</strong></td>
    </tr>
    <tr>
        <td> <span id="itemsquantity">0</span></td>
        <td>$<span id="total">0</span></td>
     </tr>
</table>

<div class="cart-buttons">
    <button id="emptycart">Empty Cart</button>
    <button id="checkout"><a href="Home/Create">Checkout</a></button>
</div>
</div>
</div>

</body>
<script src="Addtocart.js"></script>
</html>


