string query = "SELECT * FROM Users WHERE Username = @username";

SqlCommand cmd = new SqlCommand(query, connection);
cmd.Parameters.AddWithValue("@username", username);
