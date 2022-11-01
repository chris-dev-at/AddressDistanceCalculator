# AddressDistanceCalculator
Create Addresses and Calculate the distance between them using Coordinates and APIs

- Air Distance working completely
- Car Distance sometimes picking similar Addresses instead of correct one

<h2>APIs used</h2>

<h3>API NR1 MPAQUEST (MAX 15.000 Request a month for free) </h3>
http://www.mapquestapi.com/directions/v2/route?key=h3n6aCTc1Zr0x7lAAlEheH5uL2fQ3WYy&from=Start_Address&to=Destiny_Address&unit=k <br>
Used for: Getting Driving Distance <br>
Get API_KEY at https://developer.mapquest.com/user/login

<h3>API NR2 NOMINATIM (Unlimited Request, No API_KEY) </h3>
https://nominatim.openstreetmap.org/search.php?q=Some_Example_Address&format=jsonv2 <br>
Used for: Getting Coordinates 
<br> <br>
<strong>Please read the TOS (Terms of Service) from both APIs before using this code </strong>
<br> <br>
This project has been created just to prove a theory. Although the code is documented, you shouldn't expect the code to run efficient.
