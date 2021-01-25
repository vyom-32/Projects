<?php
session_start();
if(!isset($_SESSION['logged']))
{
    header("Location:index.php");
}
else{
?>
<!DOCTYPE html>
<html lang="en">
<head>
<title>Dashboard</title>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
<style>
* {
  box-sizing: border-box;
}

/* Style the body */
body {
  font-family: Arial, Helvetica, sans-serif;
  margin: 0;
}

/* Header/logo Title */
.header {
  padding: 80px;
  text-align: center;
  background: #061644;
  color:  white;
}

/* Increase the font size of the heading */
.header h1 {
  font-size: 40px;
}

/* Style the top navigation bar */
.navbar {
  overflow: hidden;
  background-color: #333;
}

/* Style the navigation bar links */
.navbar a {
  float: left;
  display: block;
  color: white;
  text-align: center;
  padding: 14px 20px;
  text-decoration: none;
}

/* Right-aligned link */
.navbar a.right {
  float: right;
}
.navbar a.left{
  float: left;
}
/* Change color on hover */
.navbar a:hover {
  background-color: #ddd;
  color: black;
}

/* Column container */
.row {  
  display: -ms-flexbox; /* IE10 */
  display: flex;
  -ms-flex-wrap: wrap; /* IE10 */
  flex-wrap: wrap;
}

/* Create two unequal columns that sits next to each other */
/* Sidebar/left column */
.side {
  -ms-flex: 20%; /* IE10 */
  flex: 20%;
  background-color: #a1c0e4;
  padding: 20px;
}

/* Main column */
.main {   
  -ms-flex: 80%; /* IE10 */
  flex: 80%;
  background-color: white;
  padding: 20px;
}

/* Footer */
.footer {
  padding: 20px;
  text-align: center;
  background: #ddd;
}

.mainimg{
  border-radius: 25px;
  width: 500px;
  box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);
  text-align: center;  
}


.img{
  border-radius: 25px;
  width: 250px;
  box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);
  text-align: center;  
}

.button {
  border-radius: 25px;
  background-color: #e7e7e7; /* Green */
  border: none;
  color: black;
  padding: 5px 22px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  font-size: 16px;
  margin: 4px 2px;
  cursor: pointer;
}

@media screen and (max-width: 700px) {
  .row {   
    flex-direction: column;
  }
}

@media screen and (max-width: 400px) {
  .navbar a {
    float: none;
    width: 100%;
  }
}
</style>

</head>
<body>

<div class="header">
  <h1>Bid Now And Grab More!!!</h1>
</div>



<div class="navbar">
    <a href="logoutVerifier.php" class="right">Log out</a>
    <a href="home.php" class="right">home</a>
    <a href="futureDeals.php" class="right">future deals</a>
    <a href="pastDeals.php" class="right">past deals</a>
</div>

<div class="row">
  <div class="side">
  <br>
  <div>
      <a href="myprofile.php"><button type="button" class="button">My Profile</button></a> 
  </div><br>
  <div>
      <a href="addproduct.php"><button type="button" class="button" >Add product</button></a>
  </div><br>
  <div>
	 <button type="button" class="button">Log</button> 
  </div>
  </div>
    <div class="main">
    <?php 
        $db = new SQLite3('db.sqlite3');
        $query="select * from user_details where id=".$_SESSION['id'].";";
        $rows=$db->query($query);
        $row = $rows->fetchArray();
    ?>
        <table border="0" width="100%">
        <tr >
            <td><h4>Name :</td>
            <td><h4><?php echo $row['name']; ?></h4></td>
        </tr>

        <tr >
            <td><h4>Username :</h4></td>
            <td><h4><?php echo $row['username']; ?></h4></td>
        </tr>
        <tr >
            <td><h4>Email address :</h4></td>
            <td><h4><?php echo $row['email']; ?></h4></td>
        </tr>
        
        </table>
        <?php if(isset($_SESSION['biderror']))
              {
                    echo $_SESSION['biderror']."<br>";
                    unset($_SESSION['biderror']);
              }
        ?>
    
    </div>
    
</div>
    

<div class="footer">
  <h2>Thank You!!! For having us.....</h2><br>
  <h3>Hope you like our work</h3>
</div>

</body>
</html>
<?php }
?>