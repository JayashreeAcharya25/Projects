<?php

 session_start();
  $connect=mysqli_connect("localhost","root","","crimedb");
 
  $fname=$_POST['fname'];
  $email=$_POST['email'];
  $password=$_POST['password']; 
  $s="SELECT * FROM `login_insert` WHERE `fname`='$fname' && `email`='$email' && `password`='$password'";
 
  $result=mysqli_query($connect,$s);
  
  $num=mysqli_num_rows($result);

  
  if($num==1){
        $home_url = '../login/user/index.php';
        header('Location: '.$home_url);
          
  }else if($fname!='fname' || $email!='email'){
        echo("<html><center><form style='border: 4px solid black; margin-top:150px; margin-left:150px; margin-right:150px;'><h2 style='color:red;'>Username or Email Not Matched!!!!</h2><p>[ If not login?? <a href='user_register.html'>Register</a> here..]</p></form></center></html>");
  }
?>  