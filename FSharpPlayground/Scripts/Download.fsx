open System.Net
open System
open System.IO

let fetchUrl callback url =
    let req = WebRequest.Create(Uri(url))
    use resp = req.GetResponse()
    use stream = resp.GetResponseStream()
    use reader = new IO.StreamReader(stream)
    callback reader url

let myCallback (reader:IO.StreamReader) url =
    let html = reader.ReadToEnd()
    let html1000 = html.Substring(0, 1000)
    printfn "Downloaded %s. First 1000 is %s" url html1000
    html

let googleOld = fetchUrl myCallback "http://google.com"

let fetchWithCallback = fetchUrl myCallback
let google = fetchWithCallback "http://google.com"
let bbc = fetchWithCallback "http://news.bbc.co.uk"

let sites = ["http://www.bing.com";
            "http://www.google.com";
            "http://www.yahoo.com"]

sites |> List.map fetchWithCallback
