using System.Collections;

namespace CustomPicker.CustomControls;

public partial class PickerX : ContentView
{
	public PickerX()
	{
		InitializeComponent();
        //this.Content.BindingContext = this;
	}

    public static readonly BindableProperty BackgroudColorPropety = BindableProperty.Create(
        propertyName: nameof(BackgroudColor),
        returnType: typeof(Color),
        declaringType: typeof(PickerX),
        defaultValue: Colors.Transparent
        );
    public Color BackgroudColor
    {
        get => (Color)GetValue(BackgroudColorPropety);
        set => SetValue(BackgroudColorPropety, value);
    }

    public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(
       propertyName: nameof(BorderColor),
       returnType: typeof(Color),
       declaringType: typeof(PickerX),
       defaultValue: Colors.LightGray
       );


    public Color BorderColor
    {
        get => (Color)GetValue(BorderColorProperty);
        set => SetValue(BorderColorProperty, value);
    }


    public static readonly BindableProperty TitleProperty = BindableProperty.Create(
       propertyName: nameof(Title),
       returnType: typeof(string),
       declaringType: typeof(PickerX)
       );


    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public static readonly BindableProperty DatasourceProperty = BindableProperty.Create(
       propertyName: nameof(Datasource),
       returnType: typeof(IList),
       declaringType: typeof(PickerX)
       
       );

    public IList Datasource
    {
        get => (IList)GetValue(DatasourceProperty);
        set => SetValue(DatasourceProperty, value);
    }

    public static readonly BindableProperty DisplayValueProperty = BindableProperty.Create(
       propertyName: nameof(DisplayValue),
       returnType: typeof(BindingBase),
       declaringType: typeof(PickerX)
       );


    public BindingBase DisplayValue
    {
        get => (BindingBase)GetValue(DisplayValueProperty);
        set => SetValue(DisplayValueProperty, value);
    }

    public static readonly BindableProperty SelectedIndexProperty = BindableProperty.Create(
       propertyName: nameof(SelectedIndex),
       returnType: typeof(int),
       declaringType: typeof(PickerX)
       );


    public int SelectedIndex
    {
        get => (int)GetValue(SelectedIndexProperty);
        set => SetValue(SelectedIndexProperty, value);
    }

    public static readonly BindableProperty SelectedItemProperty = BindableProperty.Create(
       propertyName: nameof(SelectedItem),
       returnType: typeof(int),
       declaringType: typeof(PickerX)
       );


    public object SelectedItem
    {
        get => (object)GetValue(SelectedItemProperty);
        set => SetValue(SelectedItemProperty, value);
    }
}