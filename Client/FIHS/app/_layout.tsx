import FontAwesome from "@expo/vector-icons/FontAwesome";
import {
  DarkTheme,
  DefaultTheme,
  ThemeProvider,
} from "@react-navigation/native";
import { useFonts } from "expo-font";
import { Redirect, Stack, useRouter, useSegments } from "expo-router";
import * as SplashScreen from "expo-splash-screen";
import { useEffect } from "react";
import { useColorScheme } from "@/components/useColorScheme";
import { GluestackUIProvider } from "@gluestack-ui/themed";
import { config } from "@/config/gluestack-ui.config";
import { GestureHandlerRootView } from "react-native-gesture-handler";
import { QueryClient, QueryClientProvider } from "@tanstack/react-query";
import useSession from "@/hooks/state/useSession";
import Loading from "@/components/layout/Loading";
import Toast from "react-native-toast-message";
import storage from "@/utils/storage";
export {
  // Catch any errors thrown by the Layout component.
  ErrorBoundary,
} from "expo-router";
export const unstable_settings = {
  // Ensure that reloading on `/modal` keeps a back button present.
  initialRouteName: "(tabs)",
};

// Prevent the splash screen from auto-hiding before asset loading is complete.
SplashScreen.preventAutoHideAsync();

export default function RootLayout() {
  const [loaded, error] = useFonts({
    SpaceMono: require("../assets/fonts/SpaceMono-Regular.ttf"),
    ...FontAwesome.font,
  });
  const router = useRouter();
  const { isLoading, setLoading, token, setSession } = useSession();
  useEffect(() => {
    setLoading(true);
    storage
      .load({ key: "email" })
      .then((res) => {
        setTimeout(() => {
          router.replace("/(auth)/verificationCode");
        }, 20);
      })
      .catch(() => {
        storage
          .load({ key: "refreshToken" })
          .then(async (res) => {
            console.log("refreshToken", res);

            await storage.load<Session>({ key: "session" }).then((res) => {
              console.log("session", res);

              if (res.token) {
                setSession(res);
              }
            });
          })
          .catch((err) => {
            console.log(err);
            setTimeout(() => {
              router.replace("/(auth)/login");
            }, 20);
          });
      })
      .finally(() => setLoading(false));
  }, []);
  useEffect(() => {
    if (error) throw error;
  }, [error]);
  useEffect(() => {
    if (loaded && !isLoading) {
      SplashScreen.hideAsync();
    }
  }, [loaded, isLoading]);

  if (!loaded) {
    return null;
  }

  return <RootLayoutNav token={token} />;
}

function RootLayoutNav(props: { token: string }) {
  const colorScheme = useColorScheme();
  const queryClient = new QueryClient();
  const { isLoading } = useSession();
  const segments = useSegments();
  console.log(segments);

  if (isLoading) {
    return <Loading />;
  }
  return (
    <GestureHandlerRootView style={{ flex: 1 }}>
      <QueryClientProvider client={queryClient}>
        <GluestackUIProvider config={config}>
          <ThemeProvider
            value={colorScheme === "dark" ? DarkTheme : DefaultTheme}
          >
            <Stack
              screenOptions={{ headerShown: false }}
              initialRouteName='(tabs)'
            >
              <Stack.Screen name='(tabs)' options={{ headerShown: false }} />
              <Stack.Screen name='articles' options={{ headerShown: false }} />
            </Stack>
            <Toast />
          </ThemeProvider>
        </GluestackUIProvider>
      </QueryClientProvider>
    </GestureHandlerRootView>
  );
}
