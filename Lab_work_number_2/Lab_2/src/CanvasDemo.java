
import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.layout.Pane;
import javafx.stage.Stage;

import javax.swing.*;
import java.awt.*;

/**
 * Created by Admin on 22.10.17.
 */
public class CanvasDemo extends Application {

    @Override
    public void start(Stage stage) {

        initUI(stage);
    }

    private void initUI(Stage stage) {

        Pane root = new Pane();

        Canvas canvas = new Canvas(700, 700);
        GraphicsContext gc = canvas.getGraphicsContext2D();


        root.getChildren().add(canvas);

        Scene scene = new Scene(root);

        stage.setTitle("Lines");
        stage.setScene(scene);
        stage.show();
        Executer ex = new Executer(canvas);
        ex.drawPicture(true);
    }



    public static void main(String[] args) {
        launch(args);
    }
}
