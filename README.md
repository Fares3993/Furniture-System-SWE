# Furniture System SWE

The Furniture Store Management System is a C# and ODP.Net application designed to efficiently manage various aspects of a furniture store's operations. It incorporates features like analysis, user interfaces, database operations, and report generation to streamline the store's processes. Let's provide a detailed description of each component and its functionalities:

## 1. Software Requirements Specification (SRS) Analysis:
   **- Introduction:** This section provides an overview of the furniture store management system, outlining its purpose and objectives.
   
   **- Context Diagram:** A visual representation of the system's interactions with external entities, illustrating how the system interacts with customers, products, and other external components.
   
   **- User Requirements:** The requirements specified by users or stakeholders, detailing what functionalities and features the system should possess to meet their needs.
   
   **- Functional Requirements:** Detailed descriptions of the system's functionalities, specifying how it should perform various tasks, such as user search, order management, and product information retrieval.
   
   **- Non-Functional Requirements:** Specifications related to system attributes like performance, security, reliability, and usability, ensuring the system's quality and efficiency.

## 2. Forms using ODP.Net (Connected and Disconnected Mode):
   **- First Form:**
     - Allows users to search for information about a specific user using their UserID, utilizing the connected mode of ODP.Net for database connectivity.
     - Facilitates searching for product information using the ProductID, employing a stored procedure for efficient data retrieval.
     
   **- Second Form:**
     - Enables users to view information about all users, products, or carts. The form uses the disconnected mode of ODP.Net for enhanced performance and user experience.
     - Allows users to search for a specific customer by name and display their order amount and date-time details.

## 3. Crystal Reports:
   **- First Crystal Report:**
     - Users can search for a customer by name and generate a report displaying the product title, price, discount, total cart price, and the number of carts associated with that customer.
     
   **- Second Crystal Report:**
     - Enables users to search for a customer by name and generates a report showing their previous orders.

## 4. Database and Tables:
   - The application utilizes an Oracle database containing ten tables to store relevant data:
     **- USERS:** Stores information about the store's users (customers and employees).
     
     **- PRODUCTS:** Holds details of the furniture products available for sale.
     
     **- FAVORITE:** Records the favorite products of customers.
     
     **- PAYMENT:** Stores payment-related data for completed transactions.
     
     **- CARTEDATA:** Keeps track of the items added to the cart during the shopping process.
     
     **- ORDERDATA:** Contains order-related information, such as the date, time, and total amount of an order.
     
     **- transData:** Stores information about transactions, such as order IDs and payment details.
     
     **- USER_CARTE:** Manages the relationship between users and their respective carts.
     
     **- ORDERCART:** Records the association between orders and their respective carts.
     
     **- USER_ORDER:** Manages the association between users and their orders.
<hr>

#### The Furniture Store Management System aims to streamline and automate the various tasks involved in managing a furniture store. With its user-friendly interfaces, database management capabilities, and reporting functionalities, the system enhances the overall efficiency, accuracy, and productivity of the store's operations. Users can easily search for product and customer information, track orders, and generate reports, providing a comprehensive solution to manage day-to-day activities in the furniture store effectively.

### created by a team of 4 students: 
* Fares Ahmed
* Eman Ragab
* Abdelaziz Gamal
* Abdelrahman Amro

## Some Screenshots:
<img src = "https://github.com/Fares3993/Furniture-System-SWE/assets/84674642/e2bac518-f208-4bdc-8011-acacd22d601f">
<img src = "https://github.com/Fares3993/Furniture-System-SWE/assets/84674642/ddafe360-6ada-46fe-b419-3b162ce52278">
<img src = "https://github.com/Fares3993/Furniture-System-SWE/assets/84674642/e3df3617-d7ed-4f35-acab-36e71e3328dc">
<img src = "https://github.com/Fares3993/Furniture-System-SWE/assets/84674642/657c40bc-3d67-47d4-a189-4c1d10a86fb7">
<img src = "https://github.com/Fares3993/Furniture-System-SWE/assets/84674642/d606cc21-7af2-4fa1-9652-19f2a8b7f721">
<img src = "https://github.com/Fares3993/Furniture-System-SWE/assets/84674642/ca468abf-a37a-43b4-b62e-822ee158118f">
<img src = "https://github.com/Fares3993/Furniture-System-SWE/assets/84674642/41943ca8-fbee-43bf-b13e-3de8862fc0a5">
<img src = "https://github.com/Fares3993/Furniture-System-SWE/assets/84674642/d31a95d4-10f3-47b1-8971-77b58381f615">

