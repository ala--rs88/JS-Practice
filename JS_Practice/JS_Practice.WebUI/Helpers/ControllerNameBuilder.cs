namespace JS_Practice.WebUI.Helpers
{
    public class ControllerNameBuilder
    {
        public string NameFor<TController>()
        {
            var controllerTypeName = typeof(TController).Name;

            var controllerName = controllerTypeName.Remove(controllerTypeName.IndexOf("Controller", System.StringComparison.Ordinal));

            return controllerName;
        }
    }
}