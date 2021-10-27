/**
 * InPut - Some DateTime.
 * OutPut - A string e.g. "2 years ago".
 **/
public string timeSince(DateTime inputDate)
        {
            //(current time - input time) convert to secounds = secounds ago
            double secondsAgo = DateTime.UtcNow.Subtract(Convert.ToDateTime(inputDate)).TotalSeconds;

            string outPutString = "";

            // handeles dates over 200 years ago as errors ("unknown date")
            if (secondsAgo / 31536000 >= 200)
            {
                outPutString = "Okänt datum";
            }
            else if (secondsAgo / 31536000 >= 1)
            {
                outPutString = (Math.Round(secondsAgo / 31536000)).ToString() + " år sedan";
            }

            else if (secondsAgo / 2592000 >= 1)
            {
                outPutString = (Math.Round(secondsAgo / 2592000)).ToString() + " månader sedan";
            }

            else if (secondsAgo / 604800 >= 1)
            {
                outPutString = (Math.Round(secondsAgo / 604800)).ToString() + " veckor sedan";
            }

            else if (secondsAgo / 86400 >= 1)
            {
                outPutString = (Math.Round(secondsAgo / 86400)).ToString() + " dagar sedan";
            }

            else if (secondsAgo / 3600 >= 1)
            {
                outPutString = (Math.Round(secondsAgo / 3600)).ToString() + " timmar sedan";
            }

            else
            {
                outPutString = (Math.Round(secondsAgo / 60)).ToString() + " minuter sedan";
            }
            return outPutString;
        }
