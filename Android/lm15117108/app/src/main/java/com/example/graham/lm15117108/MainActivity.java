package com.example.graham.lm15117108;

import android.content.Intent;
import android.os.StrictMode;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.Toast;

import org.json.JSONArray;
import org.json.JSONException;

import java.io.BufferedInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    String[] studentNames;
    ArrayList<Student> allStudents = new ArrayList<>();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //run network on main thread
        StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build();
        StrictMode.setThreadPolicy(policy);

        ListView mainList = (ListView) findViewById(R.id.mainList);

        //Making a http call
        HttpURLConnection urlConnection;
        InputStream in = null;
        try {
            // the url we wish to connect to
            URL url = new URL("http://www.radikaldesign.co.uk/sandbox/studentapi/getallstudents.php?apikey=e7ad175e7e");
            // open the connection to the specified URL
            urlConnection = (HttpURLConnection) url.openConnection();
            // get the response from the server in an input stream
            in = new BufferedInputStream(urlConnection.getInputStream());
        } catch (IOException e) {
            e.printStackTrace();
        }
        // covert the input stream to a string
        String response = convertStreamToString(in);
        // print the response to android monitor/log cat
        System.out.println("Server response = " + response);

        try {
            // declare a new json array and pass it the string response from the server
            // this will convert the string into a JSON array which we can then iterate
            // over using a loop
            JSONArray jsonArray = new JSONArray(response);
            // instantiate the cheeseNames array and set the size
            // to the amount of cheese object returned by the server
            studentNames = new String[jsonArray.length()];

            // use a for loop to iterate over the JSON array
            for (int i=0; i < jsonArray.length(); i++)
            {
                // the following line of code will get the name of the cheese from the
                // current JSON object and store it in a string variable called name
                String name = jsonArray.getJSONObject(i).get("name").toString();
                String gender = jsonArray.getJSONObject(i).get("gender").toString();
                String dob = jsonArray.getJSONObject(i).get("dob").toString();
                String address = jsonArray.getJSONObject(i).get("address").toString();
                String postcode = jsonArray.getJSONObject(i).get("postcode").toString();
                int studentNumber = Integer.parseInt(jsonArray.getJSONObject(i).get("studentNumber").toString());
                String courseTitle = jsonArray.getJSONObject(i).get("courseTitle").toString();
                String startDate = jsonArray.getJSONObject(i).get("startDate").toString();
                int bursary = Integer.parseInt(jsonArray.getJSONObject(i).get("bursary").toString());
                String email = jsonArray.getJSONObject(i).get("email").toString();
                // print the name to log cat
                System.out.println("name = " + name);

                Student s = new Student(name, gender, dob, address, postcode, studentNumber,
                        courseTitle, startDate, bursary, email);
                allStudents.add(s);

                // add the name of the current cheese to the cheeseNames array
                studentNames [i] = name +"\n"+ email;
            }
        } catch (JSONException e) {
            e.printStackTrace();
        }

        ArrayAdapter arrayAdapter = new ArrayAdapter( this, android.R.layout.simple_list_item_1, studentNames);
        mainList.setAdapter(arrayAdapter);

        mainList.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {

                Intent intent = new Intent(getApplicationContext(), DetailsActivity.class);
                intent.putExtra("students", allStudents.get(i));
                startActivity(intent);
            }
        });

    }

    public String convertStreamToString(InputStream is) {
        java.util.Scanner s = new java.util.Scanner(is).useDelimiter("\\A");
        return s.hasNext() ? s.next() : "";
    }
}
