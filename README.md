# Currency Converter

This is a WPF (Windows Presentation Foundation) application for converting currency values. It fetches real-time exchange rates from the OpenExchangeRates API and allows users to convert amounts between selected currencies.

## Features:

- **Live Currency Rates**: Retrieves the latest exchange rates from OpenExchangeRates.
- **Simple and Intuitive UI**: A user-friendly interface for selecting currencies and entering amounts.
- **Clear Functionality**: Easily reset the input fields with the "Clear" button.
- **Conversion Validation**: Ensures only valid numerical inputs are accepted for currency amounts.

## Technologies Used:

- **C#**: Programming language for building the application.
- **WPF (Windows Presentation Foundation)**: Framework for creating a Windows desktop application with a user-friendly UI.
- **Newtonsoft.Json**: Library for handling JSON data from the API response.
- **OpenExchangeRates API**: Provides live currency exchange rates.

## How to Run:

1. **Clone the repository to your local machine**:
    ```sh
    git clone https://github.com/mixalis-tara/CurrencyConverter.git
    ```

2. **Open the project in Visual Studio**.

3. **Restore NuGet packages**:
    - Right-click on the solution and select "Restore NuGet Packages" to ensure `Newtonsoft.Json` is available.

4. **Set up your API Key**:
    - Replace `"app_id=YOUR_API_KEY"` in the `GetValue` method with your actual OpenExchangeRates API key:
      ```csharp
      val = await GetData<Root>("https://openexchangerates.org/api/latest.json?app_id=YOUR_API_KEY");
      ```

5. **Run the Application**:
    - Press `F5` or click "Start" to launch the application.

## File Structure:

- **MainWindow.xaml**: Defines the user interface layout.
- **MainWindow.xaml.cs**: Contains the main application logic, including API integration, currency conversion logic, and event handling methods.

## Example Usage:

1. **Enter Amount**: Input the amount to be converted in the text box.
2. **Select Currencies**:
   - Choose the "From" currency and the "To" currency from the dropdowns.
3. **Convert**: Click the "Convert" button to calculate and display the converted amount.
4. **Clear**: Click the "Clear" button to reset the input fields.

## Key Methods:

- **GetData**: Retrieves the latest exchange rates from the OpenExchangeRates API.
- **BindCurrency**: Populates the currency dropdowns with the latest exchange rates.
- **Convert_Click**: Handles currency conversion logic based on the selected currencies.
- **ClearControls**: Clears the fields for a fresh input.

## Additional Information:

- Ensure you have an active internet connection, as the application fetches live data from the OpenExchangeRates API.
- You may add additional currencies or modify the UI by editing `MainWindow.xaml`.

Feel free to customize and extend this application as needed for your specific requirements.

--- 

This README provides a structured guide to setting up and running the **Currency Converter** application, with details on each feature, technology, and main functionality. Let me know if you'd like any further customization!
